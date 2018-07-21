using System;
using System.Globalization;

namespace TDDLondonSchoolWorkshop.BussinessLayer
{
    public class NumberParser : INumberParser
    {
        public double Parse(string numberToParse) =>
            double.Parse(numberToParse, CultureInfo.InvariantCulture);
    }
}
