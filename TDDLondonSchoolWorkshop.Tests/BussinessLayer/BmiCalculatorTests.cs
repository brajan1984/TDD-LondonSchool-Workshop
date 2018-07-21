using System;
using FluentAssertions;
using TDDLondonSchoolWorkshop.BussinessLayer;
using Xunit;

namespace TDDLondonSchoolWorkshop.Tests.BussinessLayer
{
    public class BmiCalculatorTests
    {
        [Theory]
        [InlineData("175;95", 31.02)]
        [InlineData("168;44", 15.6)]
        [InlineData("198;120", 30.6)]
        public void CalculateBmiFromCsv_CorrectDataIsGiven_BmiIsCalculated(string csvRow, double expectedBmi)
        {
            var calculator = new BmiCalculator();

            var calculatedBmi = calculator.CalculateBmiFromCsv(csvRow);

            calculatedBmi.Should().Be(expectedBmi);
        }
    }
}
