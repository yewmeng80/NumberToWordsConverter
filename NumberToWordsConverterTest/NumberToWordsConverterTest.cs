using Microsoft.VisualStudio.TestTools.UnitTesting;
using NumberToWordsConverter;
using System;

namespace NumberToWordsConverterTest
{
    [TestClass]
    public class NumberToWordsConverterTest
    {
        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void NumberGreaterThan999_ThrownArgumentOutOfRangeException()
        {
            NumberToWordsConverter.NumberToWordsConverter.Convert((int)1000);
        }

        [TestMethod]
        public void NumberLessThan20_ReturnNumberInWord()
        {
            var word = NumberToWordsConverter.NumberToWordsConverter.Convert((int)1);
            Assert.AreEqual(word, "ONE");

            word = NumberToWordsConverter.NumberToWordsConverter.Convert((int)19);
            Assert.AreEqual(word, "NINETEEN");
        }

        [TestMethod]
        public void NumberLessThan100_ReturnNumberInWord()
        {
            var word = NumberToWordsConverter.NumberToWordsConverter.Convert((int)90);
            Assert.AreEqual(word, "NINETY");

            word = NumberToWordsConverter.NumberToWordsConverter.Convert((int)21);
            Assert.AreEqual(word, "TWENTY-ONE");
        }

        [TestMethod]
        public void NumberLessThan1000_ReturnNumberInWord()
        {
            var word = NumberToWordsConverter.NumberToWordsConverter.Convert((int)901);
            Assert.AreEqual(word, "NINE HUNDRED AND ONE");

            word = NumberToWordsConverter.NumberToWordsConverter.Convert((int)921);
            Assert.AreEqual(word, "NINE HUNDRED AND TWENTY-ONE");
        }

        [TestMethod]
        public void NumberWithoutDecimal_ReturnNumberInWord()
        {
            var word = NumberToWordsConverter.NumberToWordsConverter.Convert((double)901);
            Assert.AreEqual(word, "NINE HUNDRED AND ONE DOLLARS");

            word = NumberToWordsConverter.NumberToWordsConverter.Convert((double)921);
            Assert.AreEqual(word, "NINE HUNDRED AND TWENTY-ONE DOLLARS");
        }

        [TestMethod]
        public void NumberWithDecimal_ReturnNumberInWord()
        {
            var word = NumberToWordsConverter.NumberToWordsConverter.Convert((double)901.20);
            Assert.AreEqual(word, "NINE HUNDRED AND ONE DOLLARS TWENTY CENTS");

            word = NumberToWordsConverter.NumberToWordsConverter.Convert((double)921.92);
            Assert.AreEqual(word, "NINE HUNDRED AND TWENTY-ONE DOLLARS NINETY-TWO CENTS");
        }
    }
}
