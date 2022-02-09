using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmPractice.DynamicProgramming
{
    class JumpGame_lint116
    {
        //青蛙跳，是否能跳到最后一格
        public bool canJump(int[] A)
        {
            // write your code here

            if (A == null || A.Length == 0)
                return false;

            int n = A.Length;
            bool[] f = new bool[n];
            f[0] = true;
            for (int i = 1; i < n; i++)
            {
                f[i] = false;
                for (int j = 0; j < i; j++)
                {
                    if (f[j] && A[j] >= (i - j))
                    {
                        f[i] = true;
                        break;
                    }
                }
            }

            return f[n - 1];
        }
    }
}
