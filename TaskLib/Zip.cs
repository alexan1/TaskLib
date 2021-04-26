using System;
using System.Linq;

namespace TaskLib
{
    public static class Zip
    {
        public static int Solution(int aa, int bb)
        {
            var s1 = aa.ToString();
            var s2 = bb.ToString();
                       
            var common = string.Concat(s1.Zip(s2, (a, b) => new[] { a, b }).SelectMany(c => c));
            var shortestLength = Math.Min(s1.Length, s2.Length);
            var result = common + s1.Substring(shortestLength) + s2.Substring(shortestLength);

            return int.Parse(result);
        }
    }
}
