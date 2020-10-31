using System;
using System.Collections.Generic;
using System.Text;

namespace TaskLib
{
    public static class PairElement
    {
        public static int FindIdenticalPairs(int[] A)
        {
            int ans = 0;

            var n = A.Length;
            for (int i = 0; i < n; i++)
                for (int j = i + 1; j < n; j++)

                    if (A[i] == A[j])
                        ans++;
            return ans;
        }
    }
}
