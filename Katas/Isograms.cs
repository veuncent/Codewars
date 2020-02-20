using System.Collections.Generic;
using System.Linq;
using NUnit.Framework;

namespace Katas
{
    public class Isograms
    {
        public static bool IsIsogram(string str)
        {
            var groups = str
                .ToLower()
                .GroupBy(c => c);

            return ! groups
                .Any(g => g.Count() > 1);
        }
    }

    [TestFixture]
    public class BasicTests
    {

        private static IEnumerable<TestCaseData> testCases
        {
            get
            {
                yield return new TestCaseData("Dermatoglyphics").Returns(true);
                yield return new TestCaseData("isogram").Returns(true);
                yield return new TestCaseData("moose").Returns(false);
                yield return new TestCaseData("isIsogram").Returns(false);
                yield return new TestCaseData("aba").Returns(false);
                yield return new TestCaseData("moOse").Returns(false);
                yield return new TestCaseData("thumbscrewjapingly").Returns(true);
                yield return new TestCaseData("").Returns(true);
            }
        }

        [Test, TestCaseSource("testCases")]
        public bool Test(string str) => Isograms.IsIsogram(str);
    }
}
