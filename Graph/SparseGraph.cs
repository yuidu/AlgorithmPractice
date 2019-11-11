using System;
using System.Collections.Generic;

namespace AlgorithmPractice
{
    public class SparseGraph : IGraph
    {
        private int n,m;
        bool isDirected;
        List<List<int>> g;
        public SparseGraph(int n, bool isDirected)
        {
            this.n = n;
            this.m = 0;
            this.isDirected = isDirected;
            g = new List<List<int>>(n);
            for(int i=0; i<n; i++)
                g.Add(new List<int>());
        }

        public int V(){return n;}
        public int E(){return m;}

         public void AddEdge(int v, int w)
         {
             //因为不过滤相同值，所以允许有平行边
             g[v].Add(w);
             if (v!=w && !isDirected)
                g[w].Add(v);
            m++;
         }  

         public bool HasEdge(int v, int w)
         {
             //允许有平行边,所以需要找所有的表
             for(int i=0; i<g[v].Count; i++)
             {
                 if (g[v][i] == w)
                 return true;
             }
             return false;
         }

         public List<int> GetAdjacentVertexes(int v)
         {
             return null;
         }
    }
}