using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace TaskLib
{
    public class Triplets
    {
        public static IList<IList<int>> ThreeSum(int[] nums)
        {

            nums = nums.OrderBy(x => x).ToArray();
            var n = nums.Length;
            IList<IList<int>> result = new List<IList<int>>();
            for (int i = 0; i < n - 2; i++)
            {
                for (int j = i + 1; j < n - 1; j++)
                {
                    for (int k = j + 1; k < n; k++)
                    {
                        if (nums[i] + nums[j] + nums[k] == 0)
                        {
                            var re = new List<int>()
                        {nums[i], nums[j], nums[k]};
                            //if (!result.Exists(x => x == nums))
                            //if (!result.Any(item => item == re))
                            if (!result.Contains(re))
                                result.Add(re);
                        }
                    }
                }
            }

            return result;
        }
    }
}
