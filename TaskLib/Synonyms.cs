using System.Collections.Generic;
using System.Linq;

namespace TaskLib
{
    public static class Words
    {
        public static List<string> Synonyms(string sentence, Dictionary<string, string> synonims)
        {
            return synonims.Select(syn => sentence.Replace(syn.Key, syn.Value)).ToList();
        }

        public static bool IsAnagram(string first, string second)
        {
            return (string.Concat(first.ToLower().OrderBy(c => c)).Equals(string.Concat(second.ToLower().OrderBy(c => c))));
        }
    }
}
