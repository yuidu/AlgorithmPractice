using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmPractice.DynamicProgramming
{
    class paintHouse1_lint515
    {
        public int minCost(int[][] costs)
        {
            // write your code here

            int n = costs.Length;
            if (n == 0)
                return 0;

            int[][] f = new int[n + 1][];
            for (int i = 0; i < n + 1; i++)
            {
                f[i] = new int[3];
                for (int j = 0; j < 3; j++)
                {
                    if (i == 0)
                        f[i][j] = 0;
                    else
                        f[i][j] = int.MaxValue;
                }
            }

            for (int i = 1; i < n + 1; i++)
            {
                f[i][0] = Math.Min(f[i - 1][1], f[i - 1][2]) + costs[i - 1][0];
                f[i][1] = Math.Min(f[i - 1][0], f[i - 1][2]) + costs[i - 1][1];
                f[i][2] = Math.Min(f[i - 1][0], f[i - 1][1]) + costs[i - 1][2];
            }

            int res = int.MaxValue;
            res = Math.Min(res, f[n][0]);
            res = Math.Min(res, f[n][1]);
            res = Math.Min(res, f[n][2]);

            return res;
        }
    }
}
