using Microsoft.VisualStudio.TestTools.UnitTesting;
using NumberToWordsConverter;
using System;

namespace NumberToWordsConverterTest
{
    [TestClass]
    public class NumberLessThan20ToWordsTest
    {
        private INumberToWords _numberToWords;

        [TestInitialize]
        public void Initialize()
        {
            _numberToWords = new NumberLessThan20ToWords();
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void NumberGreaterThan19_ThrownArgumentOutOfRangeException()
        {
            _numberToWords.Convert(20);
        }

        [TestMethod]
        public void Number_ReturnNumberInWord()
        {
            var word = _numberToWords.Convert(0);
            Assert.AreEqual(word, "ZERO");

            word = _numberToWords.Convert(1);
            Assert.AreEqual(word, "ONE");

            word = _numberToWords.Convert(2);
            Assert.AreEqual(word, "TWO");

            word = _numberToWords.Convert(3);
            Assert.AreEqual(word, "THREE");

            word = _numberToWords.Convert(4);
            Assert.AreEqual(word, "FOUR");

            word = _numberToWords.Convert(5);
            Assert.AreEqual(word, "FIVE");

            word = _numberToWords.Convert(6);
            Assert.AreEqual(word, "SIX");

            word = _numberToWords.Convert(7);
            Assert.AreEqual(word, "SEVEN");

            word = _numberToWords.Convert(8);
            Assert.AreEqual(word, "EIGHT");

            word = _numberToWords.Convert(9);
            Assert.AreEqual(word, "NINE");

            word = _numberToWords.Convert(10);
            Assert.AreEqual(word, "TEN");

            word = _numberToWords.Convert(11);
            Assert.AreEqual(word, "ELEVEN");

            word = _numberToWords.Convert(12);
            Assert.AreEqual(word, "TWELVE");

            word = _numberToWords.Convert(13);
            Assert.AreEqual(word, "THIRTEEN");

            word = _numberToWords.Convert(14);
            Assert.AreEqual(word, "FOURTEEN");

            word = _numberToWords.Convert(15);
            Assert.AreEqual(word, "FIVETEEN");

            word = _numberToWords.Convert(16);
            Assert.AreEqual(word, "SIXTEEN");

            word = _numberToWords.Convert(17);
            Assert.AreEqual(word, "SEVENTEEN");

            word = _numberToWords.Convert(18);
            Assert.AreEqual(word, "EIGHTEEN");

            word = _numberToWords.Convert(19);
            Assert.AreEqual(word, "NINETEEN");
        }
       
    }
}
