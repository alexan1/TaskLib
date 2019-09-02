﻿using System;

namespace TaskLib
{
    public static class StringHelpers
    {
        public static string GetWordFromText(string input, int wordNumberToFind)
        {
            var result = string.Empty;

            if (wordNumberToFind > 0 && !string.IsNullOrEmpty(input))
            {
                var words = input.Split(' ');

                if (wordNumberToFind < 1)
                {
                    throw new ArgumentOutOfRangeException();
                }
                else if (string.IsNullOrEmpty(input))
                {
                    throw new ArgumentNullException();
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
