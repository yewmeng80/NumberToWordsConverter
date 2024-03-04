using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace NumberToWordsConverter
{
    public interface INumberToWords
    {
        string Convert(int value);
    }
}