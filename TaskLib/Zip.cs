using System;
using System.Linq;

namespace TaskLib
{
    public static class Zip
    {

        public static int Solution(int A, int B)
        {

            var s1 = A.ToString();
            var s2 = B.ToString();
                       
            var common = string.Concat(s1.Zip(s2, (a, b) => new[] { a, b }).SelectMany(c => c));
            var shortestLength = Math.Min(s1.Length, s2.Length);
            var result = common + s1.Substring(shortestLength) + s2.Substring(shortestLength);

            return Int32.Parse(result);
        }
    }
}
