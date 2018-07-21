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
            var weightAndHeight = csvParser.Parse(row);

            double height = numberParser.Parse(weightAndHeight[0]); 
            double weight = numberParser.Parse(weightAndHeight[1]);

            return Math.Round(weight/Math.Pow((height/100), 2), 1);
        }
    }
}
