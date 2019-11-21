using System.Collections.Generic;
using System;
using System.Collections;
using System.Diagnostics;
using System.Linq;

namespace AlgorithmPractice.LeetCode
{
    public class FillOArea{
        
        private bool[,] _isVisisted;
        private int[,] _directions = new int[,]{{-1,0},{1,0},{0,1},{0,-1}};
        private char[,] _blocks;
        private bool[,] _markedEdges;
        private int _m; 
        private int _n;
        public FillOArea(char[,] blocks, int m, int n)
        {
            _isVisisted = new bool[m,n];
            _markedEdges = new bool[m,n];
            _m = m;
            _n = n;

            _blocks = blocks;
             for (int i = 0; i<m; i++)
                for(int j=0; j<n; j++)
                {
                    _isVisisted[i,j] = false;
                    _markedEdges[i,j] = false;
                }
        }

        private void MarkEdge(int p, int q)
        {
            for(int i =0; i < 4; i++)
            {   
                if (IsInArea(p,q) && _blocks[p,q] == 'O' && !_isVisisted[p,q])
                {
                    _markedEdges[p,q] = true;
                    _blocks[p,q] = 'X';

                    var lr = _directions[i, 0];
                    var td = _directions[i, 1];
                    MarkEdge(p+lr, q+td);
                }
                           
            }
        }

        private bool IsInArea(int p, int q)
        {
            if (p <0 || p > _m-1)
                return false;

            if (q <0 || q > _n-1)
                return false;

            return true;            
        }

        private void ChangeInners(int p, int q)
        {
             for(int i =0; i < 4; i++)
            {   
                if (IsInArea(p,q) && _blocks[p,q] == 'O' && !_isVisisted[p,q])
                {                    
                    _blocks[p,q] = 'X';

                    var lr = _directions[i, 0];
                    var td = _directions[i, 1];
                    MarkEdge(p+lr, q+td);
                }
                           
            }
        }

        public void Fill(char[,] block)
        {
            var m = block.GetLength(0);
            var n = block.GetLength(1);
            var isVisited = new bool[m,n];

            //mark 'O' elements of edges
            for(int i=0; i<n; i++)
            {
                MarkEdge(0,i);
                MarkEdge(m-1,i);
            }
            for(int i=0; i<m; i++)
            {
                MarkEdge(i,0);
                MarkEdge(i,n-1);
            }            

            //Change all inner 'O' to 'X'
            for (int i = 0; i<m; i++)
                for(int j=0; j<n; j++)
                {
                    if (!_isVisisted[i,j])
                        ChangeInners(i,j);
                }
            
            //Refert all marked edged 'X' back to 'O'
             for (int i = 0; i<m; i++)
                for(int j=0; j<n; j++)
                {
                    if (_markedEdges[i,j])
                        _blocks[i,j] = 'O';
                }
        }
    }
}