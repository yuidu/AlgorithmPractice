using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmPractice.DynamicProgramming
{
    public class longestContinuousSubcs
    {
        public int longestIncreasingContinuousSubsequence(int[] A)
        {
            // write your code here
            int n = A.Length;
            if (n == 0)
                return 0;

            int res = 0;
            res = getLongestSub(A);

            //reverse A;
            int i, j;
            i = 0;
            j = n - 1;
            while (i < j)
            {
                int temp = A[i];
                A[i] = A[j];
                A[j] = temp;
                i++;
                j--;
            }

            res = Math.Max(res, getLongestSub(A));

            return res;
        }

        private int getLongestSub(int[] A)
        {
            int n = A.Length;

            int[] f = new int[n];

            int res = 0;
            for (int i = 0; i < n; i++)
            {
                f[i] = 1;
                if (i - 1 >= 0 && A[i] > A[i - 1])
                    f[i] = f[i - 1] + 1;

                res = Math.Max(res, f[i]);
            }
            return res;
        }

        public void Test()
        {
            
        }
    }
}
