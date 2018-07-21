using System;
using System.Collections.Generic;

namespace TDDLondonSchoolWorkshop.BussinessLayer
{
    public interface ICsvRowParser
    {
        List<string> Parse(string row);
    }
}
