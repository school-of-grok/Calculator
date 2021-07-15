using System.Collections;
using System.Collections.Generic;

namespace Calculator
{
    public static class EasterEggs
    {
        private static readonly Dictionary<string, string> Eggs = new()
        {
            ["Life, the Universe and Everything"] = "42",
            ["How many roads must a man walk down"] = "The answer, my friend, is blowing in the wind",
        };

        public static bool TryGetEgg(string input, out string egg)
        {
            return Eggs.TryGetValue(input, out egg);
        }
    }
}
