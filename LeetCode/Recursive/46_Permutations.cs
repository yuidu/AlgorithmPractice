using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.Recursive
{
    public class _46_Permutations
    {
        // Input: nums = [1,2,3]
        // Output: [[1,2,3],[1,3,2],[2,1,3],[2,3,1],[3,1,2],[3,2,1]]
        //排列
        public void Test()
        {
            var output = Permute(new int[]{1,2,3});
            output.ToList().ForEach(x=>x.ToList().ForEach(Console.WriteLine));
        }
        public IList<IList<int>> Permute(int[] nums)
        {
            nums.ToList().ForEach(x=>isPicked.Add(new KeyValuePair<int, bool>(x,false)));
            StartToPermute(nums, 0, new List<int>());
            return res;
        }

        private IList<IList<int>> res = new List<IList<int>>();
        private IDictionary<int, bool> isPicked = new Dictionary<int, bool>();

        private void StartToPermute(int[] nums, int index, List<int> combined)
        {
            if (index == nums.Length)
                res.Add(new List<int>(combined));

            for (int i = 0; i < nums.Length; i++)
            {
                if (!isPicked[nums[i]])
                {
                    combined.Add(nums[i]);
                    isPicked[nums[i]] = true;
                    StartToPermute(nums, index + 1, combined);
                    combined.RemoveAt(combined.Count - 1);
                    isPicked[nums[i]] = false;
                }
            }
        }
    }
}
