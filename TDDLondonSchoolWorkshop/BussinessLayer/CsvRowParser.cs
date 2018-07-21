using System;
using System.Collections.Generic;
using System.Linq;

namespace TDDLondonSchoolWorkshop.BussinessLayer
{
    public class CsvRowParser : ICsvRowParser
    {
        public List<string> Parse(string row)
        {
            return row.Split(";").ToList();
        }
    }
}
