using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmPractice.DynamicProgramming
{
    public class LongestIncreasingSub_lint76
    {
        public void Test()
        {
            int[] datat = new int[5] { 9, 3, 6, 2, 7 };
            // int[] datat = new int[2] { -2, -1 };
            this.longestIncreasingSubsequence(datat);
        }

        public int longestIncreasingSubsequence(int[] nums)
        {
            // write your code here
            int n = nums.Length;
            if (n == 0)
                return 0;

            int[] f = new int[n];
            int res = 0;
            for (int i = 0; i < n; i++)
            {
                f[i] = 1;
                for (int j = 0; j < i; j++)
                {
                    if (nums[j] < nums[i] && f[j] + 1 > f[i])
                        f[i] = f[j] + 1;
                }
                res = Math.Max(f[i], res);
            }

            return res;
        }
    }
}
