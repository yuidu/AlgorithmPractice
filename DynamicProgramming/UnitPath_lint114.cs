using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmPractice.DynamicProgramming
{
    public class UnitPath_lint114
    {
        // A robot is located at the top-left corner of a m x nmxn grid.
        //     The robot can only move either down or right at any point in time.The robot is trying to reach the bottom-right corner of the grid.
        //     How many possible unique paths are there?
        public int uniquePaths(int m, int n)
        {
            // write your code here
            if (m < 1 || n < 1)
                return 0;

            int[][] f = new int[m][];

            for (int i = 0; i < m; i++)
            {
                f[i] = new int[n];
                for (int j = 0; j < n; j++)
                {
                    if (i == 0 || j == 0)
                    {
                        f[i][j] = 1;
                        continue;
                    }

                    f[i][j] = f[i - 1][j] + f[i][j - 1];
                }
            }

            return f[m - 1][n - 1];
        }
    }
}
