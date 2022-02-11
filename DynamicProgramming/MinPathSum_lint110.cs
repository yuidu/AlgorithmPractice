using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmPractice.DynamicProgramming
{
    public class MinPathSum_lint110
    {
        public int minPathSum(int[][] grid)
        {
            // write your code here
            int m = grid.Length;
            if (m == 0)
                return 0;

            int n = grid[0].Length;
            if (n == 0)
                return 0;

            int i, j;
            int[][] f = new int[m][];
            f[0][0] = grid[0][0];

            for (i = 0; i < m; i++)
            {
                f[i] = new int[n];
                for (j = 0; j < n; j++)
                {
                    if (i == 0 && j > 0)
                    {
                        f[i][j] += f[i][j - 1] + grid[i][j];
                    }
                    else if (j == 0 && i > 0)
                    {
                        f[i][j] += f[i - 1][j] + grid[i][j];
                    }
                    else
                    {
                        if (i - 1 >= 0 && j - 1 >= 0)
                            f[i][j] = Math.Min(f[i - 1][j], f[i][j - 1]) + grid[i][j];
                    }
                }
            }

            return f[m - 1][n - 1];
        }
    }
}
