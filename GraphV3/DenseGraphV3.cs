using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
namespace AlgorithmPractice
{
    //使用稠密图表示图
    public class DenseGraphV3
    {
        private int _n, _m;
        private bool[,] _g;
        private bool _isDirected;

        public int V() { return _n;}
        public int E() { return _m;}
        public DenseGraphV3(int n, bool isDirected)
        {
            this._n = n;
            this._m = 0;
            this._isDirected = isDirected;
            _g = new bool[n,n];
            for(int i=0; i<n; i++)
            {                
                for(int j=0; j<n; j++)
                    _g[i,j] = false;
            }                
        }

        public void AddEdge(int p, int q)
        {
            if (HasEdge(p,q) || p == q)
                return;

            _g[p,q] = true;
            if (!_isDirected)
                _g[q,p] = true;      

            _m++;      
        }

        public bool HasEdge(int p, int q)
        {            
            return _g[p,q];
        }

        public List<int> GetAdjacentEdges(int p)
        {
            Debug.Assert(p < _n && p >= 0);
            var edges = new List<int>();
            for(int i=0; i< _n; i++)
                if (_g[p,i] == true)
                    edges.Add(i);

            return edges;
        }
    }
}