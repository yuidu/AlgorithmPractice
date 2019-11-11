using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;

namespace AlgorithmPractice
{
    //图的遍历问题，深度优先，问题如求图的连通分量
    //看图中是否有环（有向图）
    //看从某结点到另一个结点的路径。
    public class TraverseGraphV3DFS
    {
        private SparseGraph _graph;
        private bool[] _visited;
        private int _componentCount;

        private int[] _connectState;
        private int _connectCount;

        public TraverseGraphV3DFS(SparseGraph graph)
        {
            _graph = graph;
            _visited = Enumerable.Repeat(false,_graph.V()).ToArray();
            _connectState = Enumerable.Repeat(-1, _graph.V()).ToArray();
            _connectCount = 0;
            for (int i = 0; i < graph.V(); i++)
            {
                if (!_visited[i])
                {
                    ++_connectCount;
                    Dfs(i);
                    _componentCount++;
                }
            }
        }

        //判断是否处在同一个连通分量里，通过记录每个结点所在的连在的连通分量，来实现快速判断。
        public bool isConnected(int p, int q)
        {
            return _connectState[p] == _connectState[q];
        }

        public int ComponentCount {get => _componentCount;}

        private void Dfs(int i)
        {
            _visited[i] = true;
            _connectState[i] = _connectCount;
            var allVertex = _graph.GetAdjacentVertexes(i);
            for(int j =0; j <allVertex.Count; j++)
            {                
                if (_visited[allVertex[j]])
                    Dfs(allVertex[j]);
            }
        }

    }    
}