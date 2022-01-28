using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AlgorithmPractice.matrix
{
    //850. Rectangle Area II
    // You are given a 2D array of axis-aligned rectangles.Each rectangle[i] = [xi1, yi1, xi2, yi2] denotes the ith rectangle where (xi1, yi1) are the coordinates of the bottom-left corner, and (xi2, yi2) are the coordinates of the top-right corner.
    //
    // Calculate the total area covered by all rectangles in the plane. Any area covered by two or more rectangles should only be counted once.
    //
    // Return the total area. Since the answer may be too large, return it modulo 109 + 7.
    class RectanglesArea
    {
        public int RectangleArea(int[][] rect)
        {
            HashSet<int> xv = new HashSet<int>();
            HashSet<int> yv = new HashSet<int>();
            foreach (int[] rec in rect)
            {
                xv.Add(rec[0]);
                xv.Add(rec[2]);
                yv.Add(rec[1]);
                yv.Add(rec[3]);
            }

            int[] imapx = xv.ToArray();
            int[] imapy = yv.ToArray();
            Array.Sort(imapx);
            Array.Sort(imapy);

            Dictionary<int, int> dx = new Dictionary<int, int>();
            for (int i = 0; i < imapx.Length; ++i)
            {
                dx[imapx[i]] = i;
            }

            Dictionary<int, int> dy = new Dictionary<int, int>();
            for (int i = 0; i < imapy.Length; ++i)
            {
                dy[imapy[i]] = i;
            }

            bool[][] g = new bool[imapx.Length][];
            for (int i = 0; i < imapx.Length; ++i) g[i] = new bool[imapy.Length];

            foreach (int[] rec in rect)
            {
                for (int x = dx[rec[0]]; x < dx[rec[2]]; ++x)
                {
                    for (int y = dy[rec[1]]; y < dy[rec[3]]; ++y)
                    {
                        g[x][y] = true;
                    }
                }
            }

            long area = 0;
            for (int x = 0; x < g.Length; ++x)
            {
                for (int y = 0; y < g[x].Length; ++y)
                {
                    if (g[x][y])
                    {
                        area += (long)(imapx[x + 1] - imapx[x]) * (imapy[y + 1] - imapy[y]);
                    }
                }
            }

            return (int)(area % 1000000007);
        }
    }
}
