using System;
using System.Collections.Generic;
using System.Text;

namespace TaskLib
{
    public static class Exists
    {
        public static bool Answer(int[] ints, int k)
        {
            return Array.BinarySearch(ints, k) >= 0;
        }
    }
}
