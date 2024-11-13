using System;
using System.Collections.Generic;
using System.Text;

namespace TaskLib
{
    class MainClass
    {

        public static string SearchingChallenge(string str)
        {

            int n = str.Length;
            if (n == 0) return "none";
            bool[,] varOcg = new bool[n, n];
            int start = 0; int maxLength = 1;

            for (int i = 0; i < n; i++)
                varOcg[i, i] = true;

            for (int i = 0; i < n - 1; i++)
            {
                if (str[i] == str[i + 1])
                {
                    varOcg[i, i + 1] = true;
                    start = i;
                    maxLength = 2;
                }
            }

            for (int k = 3; k <= n; k++)
            {
                for (int i = 0; i <= n - k; i++)
                {
                    int j = i + k - 1;
                    if (varOcg[i + 1, j - 1] && str[i] == str[j])
                    {
                        varOcg[i, j] = true;
                        if (k > maxLength)
                        {
                            start = i;
                            maxLength = k;
                        }
                    }
                }
            }
            if (maxLength <= 2)
                return "none";

            return str.Substring(start, maxLength);

        }
    }
}
