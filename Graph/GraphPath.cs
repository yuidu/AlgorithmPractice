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
}