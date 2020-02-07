using System.Collections.Generic;
using System.Linq;
using NUnit.Framework;

namespace Katas
{
    public class SplitString
    {
        public static string[] Solution(string str)
        {
            var lastCharacters = "";
            if (HasUnevenCharacters(str))
            {
                lastCharacters = BuildLastCharacters(str);
                str = RemoveLastCharacter(str);
            }

            var characters = str.ToCharArray();
            var splitStrings = new List<string>();
            
            AddCharacterPairs(characters, splitStrings);
            AddLastCharacters(lastCharacters, splitStrings);

            return splitStrings.ToArray();
        }

        private static bool HasUnevenCharacters(string str)
        {
            return str.Length % 2 != 0;
        }

        private static string BuildLastCharacters(string str)
        {
            return str.Last() + "_";
        }

        private static string RemoveLastCharacter(string str)
        {
            return str.Remove(str.Length - 1);
        }

        private static void AddCharacterPairs(char[] characters, List<string> splitStrings)
        {
            for (var i = 0; i < characters.Length; i += 2)
            {
                splitStrings.Add(characters[i].ToString() + characters[i + 1]);
            }
        }

        private static void AddLastCharacters(string lastCharacters, List<string> splitStrings)
        {
            if (!string.IsNullOrEmpty(lastCharacters))
            {
                splitStrings.Add(lastCharacters);
            }
        }
    }

    [TestFixture]
    public class SplitStringTests
    {
        [Test]
        public void BasicTests()
        {
            Assert.AreEqual(new string[] { "ab", "c_" }, SplitString.Solution("abc"));
            Assert.AreEqual(new string[] { "ab", "cd", "ef" }, SplitString.Solution("abcdef"));
        }
    }
}

