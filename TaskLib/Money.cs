using System;
using System.Collections.Generic;
using System.Text;

namespace TaskLib
{
    class Money
    {
        public static int CountChange(int money, int[] coins)
        {
            int[] ways = new int[money + 1];
            ways[0] = 1;

            for (int i = 0; i < coins.Length; i++)
            {
                for (int j = coins[i]; j <= money; j++)
                {
                    ways[j] += ways[j - coins[i]];
                }
            }

            return ways[money];

        }
    }
}
