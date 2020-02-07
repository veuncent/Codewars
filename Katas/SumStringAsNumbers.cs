using System;
using NUnit.Framework;
using System.Numerics;

namespace Katas
{
    public class SumStringAsNumbers
    {
        public static string sumStrings(string a, string b)
        {
            BigInteger.TryParse(a, out var aParsed);
            BigInteger.TryParse(b, out var bParsed);
            
            var total = aParsed + bParsed;

            return total.ToString();
        }
    }


    [TestFixture]
    public class CodeWarsTest
    {
        [Test]
        public void Given123And456Returns579()
        {
            Assert.AreEqual("579", SumStringAsNumbers.sumStrings("123", "456"));
        }

        [Test]
        public void Given1And456Returns579()
        {
            Assert.AreEqual("2147483747", SumStringAsNumbers.sumStrings("2147483647", "100"));
        }

        [Test]
        public void GivenLargeInputReturns131151201344081895336534324866()
        {
            Assert.AreEqual("131151201344081895336534324866", SumStringAsNumbers.sumStrings("131151201344081895336534324865", "1"));
        }

        [Test]
        public void GivenEmptyStringInputReturns0()
        {
            Assert.AreEqual("1", SumStringAsNumbers.sumStrings("", "1"));
        }


    }
}
