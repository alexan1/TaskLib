using System;

namespace TaskLib
{
    public static class SmallestPositiveInteger
    {
        public static int Solution(int[] a)
        {

            for (var i = 1; i < int.MaxValue; i++)
            {
                if (!Array.Exists(a, el => el == i))
                    return i;
            }

            return 0;
        }
    }
}
