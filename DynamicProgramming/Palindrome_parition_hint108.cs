using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmPractice.DynamicProgramming
{
    //最少可分几个回文串
    class Palindrome_parition_hint108
    {
        public int minCut(string s)
        {
            char[] cs = s.ToCharArray();
            int n = cs.Length;
            if (cs.Length == 0)
                return 0;

            bool[][] isPalin = new bool[n][];

            int i, j, t;
            for (i = 0; i < n; i++)
            {
                for (j = 0; j < n; j++)
                {
                    isPalin[i][j] = false;
                }
            }

            //generate palindrome
            for (t = 0; t < n; t++)
            {
                i = j = t;
                while (i >= 0 && j < n && s[i] == s[j])
                {
                    isPalin[i][j] = true;
                    i--;
                    j++;
                }

                i = t;
                j = t + 1;
                while (i >= 0 && j < n && s[i] == s[j])
                {
                    isPalin[i][j] = true;
                    i--;
                    j++;
                }
            }


            int[] f = new int[n + 1];
            f[0] = 0;
            for (i = 1; i <= n; i++)
            {
                f[i] = int.MaxValue;
                for (j = 0; j < i; j++)
                {
                    if (isPalin[i][j])
                    {
                        f[i] = Math.Min(f[j] + 1, f[i]);
                    }
                }
            }

            return f[n] - 1;
        }
    }
}
