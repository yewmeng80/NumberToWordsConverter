using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace NumberToWordsConverter
{
    public class NumberLessThan100ToWords : INumberToWords
    {
        private readonly Dictionary<int, string> MapNumberToWords = new Dictionary<int, string>
        {
             { 20, "TWENTY" },
             { 30, "THIRTY" },
             { 40, "FORTY" },
             { 50, "FIFTY" },
             { 60, "SIXTY" },
             { 70, "SEVENTY" },
             { 80, "EIGHTY" },
             { 90, "NINETY" }
        };
        public string Convert(int value)
        {
            if (value > 99)
                throw new ArgumentOutOfRangeException("");

            var temp = value % 10;
            if (temp > 0)
            {
                return MapNumberToWords[value - temp] + "-" + new NumberLessThan20ToWords().Convert(temp) ;
            }
            else
            {
                return MapNumberToWords[value];
            }
            
        }
    }
}