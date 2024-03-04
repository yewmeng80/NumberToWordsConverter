using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace NumberToWordsConverter
{
    public class NumberLessThan1000ToWords : INumberToWords
    {
        public string Convert(int value)
        {
            if (value > 999)
                throw new ArgumentOutOfRangeException("");

            var temp = value % 100;
            if (temp > 0)
            {
                if (temp < 20)
                {
                    return new NumberLessThan20ToWords().Convert(value / 100) + " HUNDRED AND " + new NumberLessThan20ToWords().Convert(temp);
                }
                else
                {
                    return new NumberLessThan20ToWords().Convert(value / 100) + " HUNDRED AND " + new NumberLessThan100ToWords().Convert(temp);
                }
               
            }
            else
            {
                return new NumberLessThan20ToWords().Convert(value / 100) + " HUNDRED ";
            }

        }
    }
}