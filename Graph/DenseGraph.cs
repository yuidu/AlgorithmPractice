using System;
using System.Collections.Generic;

namespace AlgorithmPractice
{
    public class DenseGraph{
        private int n; //vertex
        private int m; //edge
        bool isDirected;
        List<List<bool>> g;

        public DenseGraph(int n, bool isDirected)
        {
            n=n;
            m=0;
            isDirected = false;
             
            g = new List<List<bool>>(n);
            for(int i=0; i<n; i++)
                g.Add(new List<bool>(n));
        }

        public void AddEdge(int v, int w)
        {
            if (v < 0 || v > n-1)
             return;
             if (w < 0 || w > n-1)
             return;

            if (g[v][w])
                return;

            g[v][w] = true;
            if (!isDirected)
                g[w][v] = true;
            m++;
        }

        public bool HasEdge(int v, int w)
        {
            return g[v][w];
        }
    }
}