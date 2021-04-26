using System.Collections.Generic;
using System.Linq;

namespace TaskLib
{
    public static class Synonyms
    {
        public static List<string> Variants(string sentence, Dictionary<string, string> synonims)
        {
            return synonims.Select(syn => sentence.Replace(syn.Key, syn.Value)).ToList();
        }
    }
}
