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
            switch (input)
            {
                case null:
                    throw new ArgumentNullException();
                case "":
                    result = string.Empty;
                    break;
                default:
                {
                    var charArray = input.ToCharArray();
                    Array.Reverse(charArray);
                    result = new string(charArray);
                    break;
                }
            }
            return result;
        }

        public static string Correct(string input)
        {
            IDictionary<string, string> map = new Dictionary<string, string>()
            {
               {"a","Z"},
               {"b","Y"},
               {"c","X"},
               {"A","Z"},
               {"B","Y"},
               {"C","X"},
            };

            var regex = new Regex(string.Join("|", map.Keys));

            var output = Regex.Replace(input, @"[\d-]", string.Empty);           
            var result = regex.Replace(output, m => map[m.Value]);
            return result;
        }

    }
}
