using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace TaskLib
{
    public class Sum
    {
        public static int MaxSumDivThree(int[] nums)
        {
            var result = new List<int>();
            var n = nums.Length;
            subsetSums(nums, 0, n - 1, 0, result);

            result = result.OrderBy(x => x).ToList();

            foreach (var i in result)
            {
                if (i % 3 == 0)
                    return i;
            }
            return 0;
        }

        public static void subsetSums(int[] arr, int l, int r, int sum, List<int> result)
        {

            if (l > r)
            {
                result.Add(sum);
            }

            subsetSums(arr, l + 1, r, sum + arr[l], result);

            subsetSums(arr, l + 1, r, sum, result);
        }

    }
}
