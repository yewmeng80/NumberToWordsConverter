using Microsoft.VisualStudio.TestTools.UnitTesting;
using NumberToWordsConverter;
using System;

namespace NumberToWordsConverterTest
{
    [TestClass]
    public class NumberLessThan1000ToWordsTest
    {
        private INumberToWords _numberToWords;

        [TestInitialize]
        public void Initialize()
        {
            _numberToWords = new NumberLessThan1000ToWords();
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void NumberGreaterThan100_ThrownArgumentOutOfRangeException()
        {
            _numberToWords.Convert(1000);
        }

        [TestMethod]
        public void NumberWithModValueIsZero_ReturnNumberInWord()
        {
            var word = _numberToWords.Convert(900);
            Assert.AreEqual(word, "NINE HUNDRED ");

            word = _numberToWords.Convert(600);
            Assert.AreEqual(word, "SIX HUNDRED ");

            word = _numberToWords.Convert(300);
            Assert.AreEqual(word, "THREE HUNDRED ");

            word = _numberToWords.Convert(100);
            Assert.AreEqual(word, "ONE HUNDRED ");
        }

        [TestMethod]
        public void NumberWithModValueIsLessThan20_ReturnNumberInWord()
        {
            var word = _numberToWords.Convert(901);
            Assert.AreEqual(word, "NINE HUNDRED AND ONE");

            word = _numberToWords.Convert(604);
            Assert.AreEqual(word, "SIX HUNDRED AND FOUR");

            word = _numberToWords.Convert(308);
            Assert.AreEqual(word, "THREE HUNDRED AND EIGHT");

            word = _numberToWords.Convert(109);
            Assert.AreEqual(word, "ONE HUNDRED AND NINE");
        }

        [TestMethod]
        public void NumberWithModValueIsLessThan100_ReturnNumberInWord()
        {
            var word = _numberToWords.Convert(921);
            Assert.AreEqual(word, "NINE HUNDRED AND TWENTY-ONE");

            word = _numberToWords.Convert(640);
            Assert.AreEqual(word, "SIX HUNDRED AND FORTY");

            word = _numberToWords.Convert(338);
            Assert.AreEqual(word, "THREE HUNDRED AND THIRTY-EIGHT");

            word = _numberToWords.Convert(199);
            Assert.AreEqual(word, "ONE HUNDRED AND NINETY-NINE");
        }
    }
}
