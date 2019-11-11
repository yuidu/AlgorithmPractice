using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
namespace AlgorithmPractice
{
    public class GraphV3Path
    {
        private SparseGraphV3 _graph;
        private bool[] _isVisisted;
        private int _start;
        private int[] _from;
        public GraphV3Path(SparseGraphV3 graphV3, int start)
        {
            _graph = graphV3;
            _isVisisted = Enumerable.Repeat(false, _graph.V()).ToArray();
            _from = Enumerable.Repeat(-1, _graph.V()).ToArray();            
            _start = start;
        }

        public string FindPath(int target)
        { 
            Dfs(_start);
            return GetPath(target);
        }       

        private string GetPath(int target)
        {
            var pStack = new Stack();
            var i = target;
            pStack.Push(i);
            while(_from[i] != -1)
            {
                pStack.Push(_from[i]);
                i = _from[i];
            }

            var paths = new List<int>();
            while(pStack.Count != 0)
            {
                paths.Add((int)pStack.Pop());                                
            }
            
            return string.Join("=>", paths);
        }

        private void Dfs(int current)
        {
            _isVisisted[current] = true;
            var allVertex = _graph.GetAdjacentVertexes(current);
            for(int j=0; j<allVertex.Count; j++)
            {
                if (!_isVisisted[allVertex[j]])
                {
                    _from[allVertex[j]] = current;   //记录当前要访问的结点是从哪来的
                    Dfs(allVertex[j]);
                }                    
            }
        }

    }
}