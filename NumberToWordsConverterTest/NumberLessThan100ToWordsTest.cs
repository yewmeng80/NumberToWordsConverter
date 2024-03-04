using Microsoft.VisualStudio.TestTools.UnitTesting;
using NumberToWordsConverter;
using System;
namespace NumberToWordsConverterTest
{
    [TestClass]
    public class NumberLessThan100ToWordsTest
    {
        private INumberToWords _numberToWords;

        [TestInitialize]
        public void Initialize()
        {
            _numberToWords = new NumberLessThan100ToWords();
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void NumberGreaterThan100_ThrownArgumentOutOfRangeException()
        {
            _numberToWords.Convert(109);
        }

        [TestMethod]
        public void NumberInMapDictionary_ReturnNumberInWord()
        {
            var word = _numberToWords.Convert(20);
            Assert.AreEqual(word, "TWENTY");

            word = _numberToWords.Convert(30);
            Assert.AreEqual(word, "THIRTY");

            word = _numberToWords.Convert(40);
            Assert.AreEqual(word, "FORTY");

            word = _numberToWords.Convert(50);
            Assert.AreEqual(word, "FIFTY");

            word = _numberToWords.Convert(60);
            Assert.AreEqual(word, "SIXTY");

            word = _numberToWords.Convert(70);
            Assert.AreEqual(word, "SEVENTY");

            word = _numberToWords.Convert(80);
            Assert.AreEqual(word, "EIGHTY");

            word = _numberToWords.Convert(90);
            Assert.AreEqual(word, "NINETY");
        }

        [TestMethod]
        public void NumberWithModValueGreaterThan0_ReturnNumberInWord()
        {
            var word = _numberToWords.Convert(21);
            Assert.AreEqual(word, "TWENTY-ONE");

            word = _numberToWords.Convert(92);
            Assert.AreEqual(word, "NINETY-TWO");

            word = _numberToWords.Convert(33);
            Assert.AreEqual(word, "THIRTY-THREE");
        }

    }
}
