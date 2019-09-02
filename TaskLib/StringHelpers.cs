using System;

namespace TaskLib
{
    public static class StringHelpers
    {
        public static string GetWordFromText(string input, int wordNumberToFind)
        {
            string result;
            if (input == null)
            {
                throw new ArgumentNullException();
            }
            else
            {
                var words = input.Split(' ');
                
                if (wordNumberToFind < 1)
                {
                    throw new ArgumentOutOfRangeException();
                }               
                else if (words.Length < wordNumberToFind)
                {
                    throw new ArgumentException();
                }
                else
                {
                    result = words[wordNumberToFind - 1];
                }
            }
            return result;
        }

        public static string Reverse(string input)
        {
            string result;
            if (string.IsNullOrEmpty(input))
            {
                throw new ArgumentNullException();
            }
            else
            {
                char[] charArray = input.ToCharArray();
                Array.Reverse(charArray);
                result = new string(charArray);
            }
            return result;
        }

    }
}
