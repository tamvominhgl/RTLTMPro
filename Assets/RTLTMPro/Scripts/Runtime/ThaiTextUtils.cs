using System;
using System.Collections.Generic;

namespace RTLTMPro
{
    public static class ThaiTextUtils
    {
        public static bool IsThaiText(string input)
        {
            bool insideTag = false;
            foreach (char character in input)
            {
                switch (character)
                {
                    case '<':
                        insideTag = true;
                        continue;

                    case '>':
                        insideTag = false;
                        continue;
                }

                if (insideTag)
                {
                    continue;
                }

                if (char.IsLetter(character))
                {
                    return IsThaiCharacter(character);
                }
            }

            return false;
        }

        static bool IsThaiCharacter(char ch) {
            return ch >= (char) 0xE00 && ch <= (char) 0xE7F;
        }
    }
}