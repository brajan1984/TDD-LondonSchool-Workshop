using System;
using FluentAssertions;
using TDDLondonSchoolWorkshop.BussinessLayer;
using Xunit;

namespace TDDLondonSchoolWorkshop.Tests.BussinessLayer
{
    public class CsvRowParserTests
    {
        [Theory]
        [InlineData("123;14;5", new string[] { "123", "14", "5" })]
        [InlineData("12;1", new string[] { "12", "1" })]
        public void Parse_GivingStandardRecord_CountOfElementsEqualsToCountOfElementsExpected(string csvRow, string[] expectedResult)
        {
            //Arrange
            var parser = new CsvRowParser();

            //Act
            var result = parser.Parse(csvRow);

            //Assert
            result.Should().BeEquivalentTo(expectedResult);
        }
    }
}
