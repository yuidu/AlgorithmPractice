using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Linq;

namespace AlgorithmPractice.matrix
{
    
    class Canvas
    {
        private int[][] _g;
        private int _m;
        private int _n;

        public void Create(int m, int n)
        {
            _m = m;
            _n = n;
            _g = new int[m][];
            for (int i = 0; i < m; i++)
                _g[i] = new int[n];
        }

        public void DrawRect(int x1, int y1, int x2, int y2)
        {
            if (!(IsInArea(x1, y1) && IsInArea(x2, y2)))
                return;

            for (int i = x1; i <= x2; i++)
                for (int j = y1; j <= y2; j++)
                    _g[i][j] = 1;
        }

        
        private bool IsInArea(int x, int y)
        {
            return x >= 0 && x < _n && y >= 0 && y < _m;
        }
    }
}
