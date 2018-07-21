using System;
using System.Collections.Generic;
using FluentAssertions;
using Moq;
using TDDLondonSchoolWorkshop.BussinessLayer;
using Xunit;

namespace TDDLondonSchoolWorkshop.Tests.BussinessLayer
{
    public class BmiCalculatorTests
    {
        [Theory]
        [InlineData("175;95", "175", "95", 175, 95, 31.0)]
        [InlineData("168;44", "168", "44", 168, 44,  15.6)]
        [InlineData("198;120", "198", "120", 198, 120, 30.6)]
        public void CalculateBmiFromCsv_CorrectDataIsGiven_BmiIsCalculated(string csvRow, string height, string weight, int heightNo, int weightNo, double expectedBmi)
        {
            //Arrange
            var csvParserMock = new Mock<ICsvRowParser>();
            var numberParserMock = new Mock<INumberParser>();

            csvParserMock.Setup(c => c.Parse(csvRow)).Returns(new List<string> { height, weight });
            numberParserMock.Setup(c => c.Parse(height)).Returns(heightNo);
            numberParserMock.Setup(c => c.Parse(weight)).Returns(weightNo);

            var calculator = new BmiCalculator(csvParserMock.Object, numberParserMock.Object);

            //Act
            var calculatedBmi = calculator.CalculateBmiFromCsv(csvRow);

            //Assert
            calculatedBmi.Should().Be(expectedBmi);
        }
    }
}
