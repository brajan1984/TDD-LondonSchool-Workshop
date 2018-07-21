using System;
using FluentAssertions;
using TDDLondonSchoolWorkshop.BussinessLayer;
using Xunit;

namespace TDDLondonSchoolWorkshop.Tests.BussinessLayer
{
    public class NumberParserTests
    {
        [Theory]
        [InlineData("24.6", 24.6)]
        [InlineData("123.678", 123.678)]
        public void Parse_GivenNumberToParse_CorrectlyParsed(string toParse, double expectedResult)
        {
            //Arrange
            var parser = new NumberParser();

            //Act
            var result = parser.Parse(toParse);

            //Assert
            result.Should().Be(expectedResult);
        }
    }
}
