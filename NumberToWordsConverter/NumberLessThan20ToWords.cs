using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace NumberToWordsConverter
{
    public class NumberLessThan20ToWords : INumberToWords
    {
        private readonly Dictionary<int, string> MapNumberToWords = new Dictionary<int, string>
        {
             { 0, "ZERO" },
             { 1, "ONE" },
             { 2, "TWO" },
             { 3, "THREE" },
             { 4, "FOUR" },
             { 5, "FIVE" },
             { 6, "SIX" },
             { 7, "SEVEN" },
             { 8, "EIGHT" },
             { 9, "NINE" },
             { 10, "TEN" },
             { 11, "ELEVEN" },
             { 12, "TWELVE" },
             { 13, "THIRTEEN" },
             { 14, "FOURTEEN" },
             { 15, "FIVETEEN" },
             { 16, "SIXTEEN" },
             { 17, "SEVENTEEN" },
             { 18, "EIGHTEEN" },
             { 19, "NINETEEN" }
        };
        public string Convert(int value)
        {
            if (value > 19)
                throw new ArgumentOutOfRangeException("");

            return MapNumberToWords[value];
        }
    }
}