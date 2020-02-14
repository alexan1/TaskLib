using System.Linq;

namespace TaskLib
{
    public static class Mobi
    {
        public static string MostCommonWord(string text)
        {
            return text.Split(' ').GroupBy(x => x).Select(x => new { KeyField = x.Key, Count = x.Count() })
            .OrderByDescending(x => x.Count).First().KeyField.ToString();
        }
    }
}
