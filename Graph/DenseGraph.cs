using System;
using System.Collections;
using System.Collections.Generic;

namespace AlgorithmPractice
{
    public class DenseGraph : IGraph{
        private int n; //vertex
        private int m; //edge
        bool isDirected;
        List<List<bool>> g;

        public DenseGraph(int n, bool isDirected)
        {
            this.n=n;
            this.m=0;
            this.isDirected = isDirected;
             
            g = new List<List<bool>>(n);
            for(int i=0; i<n; i++)
                g.Add(new List<bool>(n));
        }

        public List<int> GetAdjacentVertexes(int v)
        {
            var adjacentVs = new List<int>();
            if (v > g.Count)
                return adjacentVs;

            for(int i=0; i<g[v].Count; i++)
            {
                if (g[v][i])
                    adjacentVs.Add(i);
            }
            return adjacentVs;
        }


        public int V(){return n;}
        public int E(){return m;}
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