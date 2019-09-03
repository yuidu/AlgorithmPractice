using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace AlgorithmPractice {
    ///
    /// 
    ///
    ///
    public class SparseGraphV2 {
        private int _numberOfVertex;
        private int _numberOfEdges;
        private bool _isDirected;

        private List<List<int>> _g;
        public SparseGraphV2 (int numberOfVertex, bool isDirected) {
            _numberOfVertex = numberOfVertex;
            _numberOfEdges = 0;
            _isDirected = isDirected;
            _g = new List<List<int>> (_numberOfVertex);
            for (int i = 0; i < _numberOfVertex; i++) {
                _g.Add (new List<int> ());
            }
        }

        public int NumberOfVertex { get { return _numberOfVertex; } }
        public int NumberOfEdge { get { return _numberOfEdges; } }

        public void AddEdge (int m, int n) {
            if (m < 0 || m > _numberOfVertex)
                return;
            if (n < 0 || n > _numberOfVertex)
                return;

            _g[m].Add (n);
            if (m != n && !_isDirected)
                _g[n].Add (m);

            _numberOfEdges++;
        }

        public bool HasEdge (int m, int n) {
            if (m < 1 || m > _numberOfVertex)
                return false;
            if (n < 1 || n > _numberOfVertex)
                return false;

            for (int k = 0; k < _g[m].Count; k++) {
                if (_g[m][k] == n)
                    return true;
            }

            return false;
        }

        public List<int> GetVertexes (int curr) {
            if (curr < 0 || curr > _numberOfVertex)
                return new List<int> ();

            return _g[curr];
        }
    }

    public class TraverseGraphV2 {

        private List<bool> _visitedList;
        private SparseGraphV2 _graph;
        private Queue _queue;
        public TraverseGraphV2 (SparseGraphV2 graph) {
            _graph = graph;
            ResetVisitedList ();
        }

        private void ResetVisitedList () {
            _visitedList = Enumerable.Repeat (false, _graph.NumberOfVertex).ToList ();
        }

        public void TraverseGraphFromUsingDfs (SparseGraphV2 graph, int startPos) {
            if (startPos < 0 || startPos > graph.NumberOfVertex)
                return;

            Dfs (graph, startPos);
        }

        public void TraverseGraphFromUsingBfs (int startPos) {
            if (startPos < 0 || startPos > _graph.NumberOfVertex)
                return;

            ResetVisitedList ();
            _queue = new Queue ();

            _queue.Enqueue (startPos);
            Bfs ();
        }

        public int GetComponentCount () {
            int componentCount = 0;
            for (int i = 0; i < _graph.NumberOfVertex; i++) {
                if (!_visitedList[i]) {
                    Dfs (_graph, i);
                    componentCount++;
                }
            }
            return componentCount;
        }

        private void Dfs (SparseGraphV2 g, int p) {
            Console.Write (p + ",");
            _visitedList[p] = true;
            var children = g.GetVertexes (p);
            for (int i = 0; i < children.Count; i++) {
                if (!_visitedList[children[i]])
                    Dfs (g, children[i]);
            }
        }

        private void Bfs () {
            if (_queue.Count == 0)
                return;

            int e = (int) _queue.Dequeue ();
            _visitedList[e] = true;
            Console.WriteLine (e + ",");
            _graph.GetVertexes (e).ForEach (x => {
                if (!_visitedList[x] && !_queue.Contains (x)) {
                    _queue.Enqueue (x);
                }
            });
            Bfs();             
        }
    }
}