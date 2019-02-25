using System;
using System.Collections.Generic;

namespace AlgorithmPractice
{
    public class GraphPath
    {
        private IGraph graph;
        public GraphPath(IGraph graph)
        {
            this.graph = graph;
        }

        public void GetPath(int fr, int to)
        {
            var traverse = new TraverseGraph(graph);
            traverse.Dfs(fr);
            
            var s = new Stack<int>();
            s.Push(to);
            while(fr != to)            
            {
                s.Push(traverse.from[to]);
                to = traverse.from[to];
            }

            Console.WriteLine("");
            while(s.Count > 0)
            {
                Console.Write(s.Pop());
            }            
        }
    }


    public class TraverseGraph{
        public bool[] visitedVertex;
        public int[] from;        
        private IGraph graph;        
        public TraverseGraph(IGraph graph)
        {
            this.graph = graph;
            var vCount = graph.V();
            
            if (vCount > 0)
            {
                visitedVertex = new bool[vCount];
                for(int i=0;  i<vCount; i++)
                    visitedVertex[i] = false;

                from = new int[vCount];
                for(int i=0;  i<vCount; i++)
                from[i] = -1;
            }                
        }

        public void Dfs(int v)
        {
            Console.Write(v);
            visitedVertex[v] = true;
            var vs = graph.GetAdjacentVertexes(v);
            for(int i=0; i<vs.Count; i++)
            {
                if (!visitedVertex[vs[i]])
                {
                    from[vs[i]] = v;
                    Dfs(vs[i]);
                }                    
            }            
        }

       
    }
}