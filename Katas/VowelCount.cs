using System.Collections.Generic;
using System.Linq;
using NUnit.Framework;

namespace Katas
{
    public static class VowelCount
    {
        public static int GetVowelCount(string str)
        {
            var vowels = new List<string> {"a", "e", "i", "o", "u"};
            
            return str.Count(c => vowels.Contains(c.ToString()));
        }
    }

    [TestFixture]
    public class KataTests
    {
        [Test]
        public void TestCase1()
        {
            Assert.AreEqual(5, VowelCount.GetVowelCount("abracadabra"), "Nope!");
        }
    }
}
