using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmPractice.DynamicProgramming
{
    class backpack_lint563
    {
        //有多少种组合可以拼出target
        // public int backPackV(int[] nums, int target)
        // {
        //     // write your code here
        //     int n = nums.length;
        //     if (n == 0)
        //         return 0;
        //
        //     int m = target;
        //     int[][] f = new int[n + 1][m + 1];
        //     f[0][0] = 1;
        //     for (int j = 1; j <= m; j++)
        //     {
        //         f[0][j] = 0;
        //     }
        //
        //     for (int i = 1; i <= n; i++)
        //     {
        //         for (int j = 0; j <= m; j++)
        //         {
        //             if (j - nums[i - 1] >= 0)
        //                 f[i][j] = f[i - 1][j] + f[i - 1][j - nums[i - 1]];
        //         }
        //     }
        //
        //     return f[n][m];
        // }
    }
}
