using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;

namespace AlgorithmPractice
{
    public class TraverseGraphBFS
    {
        private SparseGraphV3 _graph;
        private bool[] _isVisited;
        private int[] _from;
        private int[] _height;
        private Queue _gQueue;
        public TraverseGraphBFS(SparseGraphV3 graph)
        {
            _graph = graph;
            _isVisited = Enumerable.Repeat(false, _graph.V()).ToArray();
            _from = Enumerable.Repeat(-1, _graph.V()).ToArray();
            _height = Enumerable.Repeat(0, _graph.V()).ToArray();
            _gQueue = new Queue();
        }

        public string FindPath(int start, int target, out int height)
        {
            Bfs(start);                    
            height = _height[target];
            return GetPath(target);
        }

        private string GetPath(int target)
        {
            var pStack = new Stack();
            int i = target;
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


        //递归的实现
        // private void Bfs(int current)
        // {
        //     _isVisited[current] = true;            
        //     var adjacentVertexes = _graph.GetAdjacentVertexes(current);
        //     adjacentVertexes.ForEach(x=>{
        //         if (!_isVisited[x] && !_gQueue.Contains(x))
        //         {
        //             _from[x] = current;
        //             _gQueue.Enqueue(x);
        //         }
                    
        //     });

        //     while(_gQueue.Count != 0)
        //     {
        //         Bfs((int)_gQueue.Dequeue());
        //     }
        // }

        //非归递实现
        private void Bfs(int start)
        {            
            _gQueue.Enqueue(start);
            while(_gQueue.Count != 0)
            {
                var current = (int)_gQueue.Dequeue();
                _isVisited[current] = true;
                var adjacentVertex = _graph.GetAdjacentVertexes(current);
                for(int i=0; i<adjacentVertex.Count; i++)
                {
                    var child = adjacentVertex[i];
                    if (!_isVisited[child] && !_gQueue.Contains(child))
                    {
                        _gQueue.Enqueue(child);
                        _from[child] = current;
                        _height[child] = _height[current] + 1;
                    }                        
                }                
            }
        }
    }
}

//广度优先遍历求出了无权图的最短路径，事实上因为从遍历的起始点开始，每次遍历到的点由于层次递增，所以路径在不断的增加，找到了目标结点那自然是最短的

