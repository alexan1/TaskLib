using System.Collections.Generic;
using System.Linq;

namespace TaskLib
{
    public class Sum
    {
        public static int MaxSumDivThree(int[] nums)
        {
            var result = new List<int>();
            var n = nums.Length;
            SubsetSums(nums, 0, n - 1, 0, result);

            result = result.OrderBy(x => x).ToList();

            return result.FirstOrDefault(i => i % 3 == 0);
        }

        public static void SubsetSums(int[] arr, int l, int r, int sum, List<int> result)
        {

            if (l > r)
            {
                result.Add(sum);
            }

            SubsetSums(arr, l + 1, r, sum + arr[l], result);

            SubsetSums(arr, l + 1, r, sum, result);
        }

    }
}
