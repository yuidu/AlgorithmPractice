using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmPractice.DynamicProgramming
{
    class longestCommonString
    {
    //     public int findLength(int[] A, int[] B)
    //     {
    //         int[][] dp = new int[A.length + 1][B.length + 1];
    //         if (A == null || B == null)
    //         {
    //             return 0;
    //         }
    //         int max = 0;
    //         for (int i = 0; i < A.length; i++)
    //         {
    //             for (int j = 0; j < B.length; j++)
    //             {
    //                 if (A[i] == B[j])
    //                 {
    //                     dp[i + 1][j + 1] = dp[i][j] + 1;
    //                 }
    //                 else
    //                 {
    //                     dp[i + 1][j + 1] = 0;
    //                 }
    //                 max = Math.max(max, dp[i + 1][j + 1]);
    //             }
    //         }
    //         return max;
    //     }
    // }
}
}
