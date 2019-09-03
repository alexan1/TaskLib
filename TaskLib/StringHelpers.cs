using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

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
                var words = input.Trim().Split(' ');
                
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
            if (input == null)
            {
                throw new ArgumentNullException();
            }
            else if (input == string.Empty)
            {
                result = string.Empty;
            }
            else
            {
                char[] charArray = input.ToCharArray();
                Array.Reverse(charArray);
                result = new string(charArray);
            }
            return result;
        }

        public static string Correct(string input)
        {
            IDictionary<string, string> map = new Dictionary<string, string>()
            {
               {"a","X"},
               {"b","Y"},
               {"c","Z"},
               {"A","X"},
               {"B","Y"},
               {"C","Z"},
            };

            var regex = new Regex(String.Join("|", map.Keys));

            string result = string.Empty;

            var output = Regex.Replace(input, @"[\d-]", string.Empty);
            //result = output.Replace('a', 'X').Replace('A', 'X').Replace('b', 'Y').Replace('B', 'Y').Replace('c', 'Z').Replace('C', 'Z');
            //result = Regex.Replace(output, "a", "X", RegexOptions.IgnoreCase);

            result = regex.Replace(output, m => map[m.Value]);

            return result;
        }

    }
}
