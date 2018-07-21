using System;

namespace TDDLondonSchoolWorkshop.BussinessLayer
{
    public class BmiCalculator
    {
        private readonly ICsvRowParser csvParser;
        private readonly INumberParser numberParser;
        public BmiCalculator(ICsvRowParser csvParser, INumberParser numberParser)
        {
            this.numberParser = numberParser;
            this.csvParser = csvParser;
        }
        public double CalculateBmiFromCsv(string row)
        {
            throw new NotImplementedException();
        }
    }
}
