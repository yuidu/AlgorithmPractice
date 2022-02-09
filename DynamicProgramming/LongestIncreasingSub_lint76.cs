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
            this.longestIncreasingSubsequence(datat);
        }

        public int longestIncreasingSubsequence(int[] nums)
        {
            // write your code here
            int n = nums.Length;
            if (n == 0)
                return 0;

            int i, j;
            int[] f = new int[n + 1];
            f[0] = 0;
            for (i = 1; i <= n; i++)
            {
                f[i] = 1;
                for (j = 0; j < i; j++)
                {
                    if (j - 1 >= 0 && nums[j - 1] < nums[i - 1])
                        f[i] = f[j] + 1;
                }
            }

            int res = 0;
            for (i = n; i >= 0; i--)
                res = Math.Max(res, f[i]);

            return res;
        }
    }
}
