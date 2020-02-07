using System.Collections.Generic;
using System.Text;
using NUnit.Framework;

namespace Katas
{
    public class Kata
    {
        public static string PigIt(string str)
        {
            var stringBuilder = new StringBuilder();
            var words = str.Split(' ');

            for (var i = 0; i < words.Length; i++)
            {
                AppendCharactersAfterFirst(words, i, stringBuilder);
                AppendFirstCharacter(words, i, stringBuilder);
                AppendAy(stringBuilder);
                AppendSpace(i, words, stringBuilder);
            }

            return stringBuilder.ToString();
        }

        private static void AppendCharactersAfterFirst(IReadOnlyList<string> words, int i, StringBuilder stringBuilder)
        {
            var charactersAfterFirst = words[i].Substring(1);
            stringBuilder.Append(charactersAfterFirst);
        }

        private static void AppendFirstCharacter(IReadOnlyList<string> words, int i, StringBuilder stringBuilder)
        {
            var firstCharacter = words[i].Substring(0, 1);
            stringBuilder.Append(firstCharacter);
        }

        private static void AppendAy(StringBuilder stringBuilder)
        {
            stringBuilder.Append("ay");
        }

        private static void AppendSpace(int i, IReadOnlyCollection<string> words, StringBuilder stringBuilder)
        {
            if (i != words.Count - 1)
            {
                stringBuilder.Append(" ");
            }
        }
    }

    [TestFixture]
    public class KataTest
    {
        [Test]
        public void KataTests()
        {
            Assert.AreEqual("igPay atinlay siay oolcay", Kata.PigIt("Pig latin is cool"));
            Assert.AreEqual("hisTay siay ymay tringsay", Kata.PigIt("This is my string"));
        }
    }
}