using System.Collections.Generic;

namespace TaskLib
{
    public static class Synonyms
    {
        public static List<string> Variants(string sentence, Dictionary<string, string> synonims)
        {
            var result = new List<string>();

            foreach (var syn in synonims)
            {                 
                    result.Add(sentence.Replace(syn.Key, syn.Value));               
            }

            return result;
        }
    }
}
