using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.ListSetmap
{
    class TwoSum
    {
        public int[] CalTwoSum(int[] nums, int target)
        {
            var record = new Dictionary<int, int>();
            for (int i = 0; i < nums.Length; i++)
            {
                if (record.ContainsKey(target - nums[i]))
                    return new int[] { record[target - nums[i]], i };

                if (!record.ContainsKey(nums[i]))
                    record.Add(nums[i], i);
            }

            return new int[2] { 0, 0 };
        }
    }
}
