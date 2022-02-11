using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmPractice.DynamicProgramming
{
    public class longestCommonString
    {
        public void Test()
        {

        }
        public int getLongestCommonString(int[] A, int[] B)
        {   
            
            if (A == null || B == null)
            {
                return 0;
            }

            int[][] dp = new int[A.Length + 1][];
 
            int max = 0;
            for (int i = 0; i < A.Length; i++)
            {
                dp[i] = new int[B.Length + 1];
                for (int j = 0; j < B.Length; j++)
                {
                    if (A[i] == B[j])
                    {
                        dp[i + 1][j + 1] = dp[i][j] + 1;
                    }
                    else
                    {
                        dp[i + 1][j + 1] = 0;
                    }
                    max = Math.Max(max, dp[i + 1][j + 1]);
                }
            }
            return max;
        }
    }
}

