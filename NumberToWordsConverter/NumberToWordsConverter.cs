using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace NumberToWordsConverter
{
    public class NumberToWordsConverter
    {
        public static string Convert(double value)
        {
            var integerValue = (int)value;
            var decimalValue = (int)Math.Round((value - (double)(integerValue)) * 100);
            if (decimalValue > 0)
            {
                return Convert(integerValue) + " DOLLARS " + Convert(decimalValue) + " CENTS";
            }
            else
            {
                return Convert(integerValue) + " DOLLARS";
            }
        }

        public static string Convert(int value)
        {
            if (value < 20)
            {
                return new NumberLessThan20ToWords().Convert(value);
            }
            if (value < 100)
            {
                return new NumberLessThan100ToWords().Convert(value);
            }
            if (value < 1000)
            {
                return new NumberLessThan1000ToWords().Convert(value);
            }
            else
            {
                throw new ArgumentOutOfRangeException("");
            }
        }
    }
}