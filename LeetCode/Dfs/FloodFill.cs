using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.Dfs
{
    class FloodFills
    {
        public int[][] FloodFill(int[][] image, int sr, int sc, int newColor)
        {
            int m = image.Length;
            int n = image[0].Length;

            bool[][] bVisited = new bool[m][];
            for (int i = 0; i < m; i++)
            {
                bVisited[i] = new bool[n];
                for (int j = 0; j < n; j++)
                    bVisited[i][j] = false;
            }

            Dfs(image, sr, sc, newColor, bVisited);
            return image;
        }


        private void Dfs(int[][] image, int sr, int sc, int newColor, bool[][] bVisited)
        {
            int[][] directions = new int[4][];
            directions[0] = new int[2];
            directions[0][0] = -1;
            directions[0][1] = 0;
            directions[1] = new int[2];
            directions[1][0] = 1;
            directions[1][1] = 0;
            directions[2] = new int[2];
            directions[2][0] = 0;
            directions[2][1] = -1;
            directions[3] = new int[2];
            directions[3][0] = 0;
            directions[3][1] = 1;

            if (!bVisited[sr][sc])
            {
                image[sr][sc] = newColor;
                bVisited[sr][sc] = true;

                for (int i = 0; i < 4; i++)
                {
                    int newSr = sr + directions[i][0];
                    int newSc = sc + directions[i][1];
                    Dfs(image, newSr, newSc, newColor, bVisited);
                }
            }
        }
    }
}
