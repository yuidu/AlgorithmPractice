using System;
using System.Collections.Generic;

namespace AlgorithmPractice
{
    public interface IGraph{
         void AddEdge(int v, int w);
         bool HasEdge(int v, int w);
         int V();
         int E();
         List<int> GetAdjacentVertexes(int v);
    }
}
    
