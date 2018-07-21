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

            return CalculateBmi(weight, height);
        }

        private double CalculateBmi(double weightInKg, double heightInCm)
        {
            return Math.Round(weightInKg/Math.Pow((heightInCm/100), 2), 1);
        }
    }
}
