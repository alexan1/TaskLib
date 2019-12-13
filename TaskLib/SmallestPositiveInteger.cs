using System;

namespace TaskLib
{
    public static class SmallestPositiveInteger
    {
        public static int Solution(int[] A)
        {

            for (var i = 1; i < Int32.MaxValue; i++)
            {
                if (!Array.Exists(A, el => el == i))
                    return i;
            }

            return 0;
        }
    }
}
