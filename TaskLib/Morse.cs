using System.Collections.Generic;
using System.Linq;

namespace TaskLib
{
    public static class Morse
    {
        public static List<string> Possibilities(string word)
        {

            var translator = new Dictionary<string, string>()
    {
                {".-", "A"},
                {"-..", "D"},
                {".", "E"},
                {"--.", "G"},
                {"..", "I"},
                {"-.-", "K"},
                {"--", "M"},
                {"-.", "N"},
                {"---", "O"},
                {".-.", "R"},
                {"...", "S"},
                {"-", "T"},
                {"..-", "U"},
                {".--", "W"},
                {"?", "E"},
    };

            var words = new List<string>();

            if (word.Contains("?"))
            {
                words.Add(word.Replace('?', '.'));
                words.Add(word.Replace('?', '-'));
            }
            else
                words.Add(word);

            return words.Select(w => translator[w]).ToList();
        }
    }
}
