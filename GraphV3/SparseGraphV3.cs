using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
namespace AlgorithmPractice
{

//图需要考虑的问题 1. 自环边，2. 平行边  3. 怎么高效的查找某结点的邻边
 public class SparseGraphV3
 {
     private int _n, _m;   //n: vetex, m: edges
     private bool _isDirected;
     private List<List<int>> _g;

     public int V() {return _n;}
     public int E() {return _m;}
     public SparseGraphV3(int n, bool isDirected)
     {
         this._n = n;
         this._m = 0;
         this._isDirected = isDirected;

         _g = new List<List<int>>();
         for(int i=0; i<n; i++)
         {
             _g.Add(new List<int>());
         }      
     }

     public void AddEdge(int p, int q)
     {
         Debug.Assert(p < _n);
        //  if (HasEdge(p,q))   //这个处理是过滤到了平行边，那么AddEdge就变成了O(n)的复杂度而不是O(1)了，稀疏图的复杂度就比邻接表更高了。
        //     return;

         _g[p].Add(q);
         if (p !=q && !_isDirected)
            _g[q].Add(p);

        _m++;
     }

    //可用于处理自环边
     public bool HasEdge(int p, int q)
     {
         return _g[p].Contains(q);
     }

     public List<int> GetAdjacentVertexes(int p)
     {
         Debug.Assert(p >=0 && p < _n);
         return _g[p];
     }
 }  
}