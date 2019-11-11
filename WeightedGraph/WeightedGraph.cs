using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
namespace AlgorithmPractice
{
    //带权图的问题：带权图的最小生成树问题
    //如电缆布线问题，保证所有的结点都能通电，同时费用最低
    //针对带权无向图，并且是连通图
    public class EdgeV3
    {
        public int V; //current node
        public int W; //Other node
        public int Weight;

        public EdgeV3(int v, int w, int weight)
        {
            this.V = v;
            this.W = w;
            this.W = weight;
        }
    }

    //使用邻接表表示带权图, 每个元素是一个edge对象，记录另一个顶点及权值
    // 4  {3: 0.2},{8: 0.5},...
    // 8  {4: 0.2}
    // 
    public class WeightedSparseGraph
    {
        private List<List<EdgeV3>> _items;
        private int _numberOfVertex;        
        private bool _isDirected;
        private int _numberOfEdges;
        public int V(){return _numberOfVertex;}  //顶点数
        public int E(){return _numberOfEdges;}  //表数

        public WeightedSparseGraph(int numberOfVertex, bool isDirected)
        {
            this._numberOfVertex = numberOfVertex;
            this._isDirected = isDirected;            
            _numberOfEdges = 0;
            this._items = new List<List<EdgeV3>>(numberOfVertex);
            for(int i=0; i<_items.Count;i++)
                _items[i] = new List<EdgeV3>();
        }

        public void AddEdge(int v, int w, int value)
        {
            if (v == w)  //去除自环边
                return;
            
            _items[v].Add(new EdgeV3(v,w,value));
            if (!_isDirected)
                _items[w].Add(new EdgeV3(w,v,value));

            _numberOfEdges++;
        }

        public bool HasEdge(int v, int w)
        {
            if (v < 0|| v >_numberOfVertex
            || w < 0|| w >_numberOfVertex)
                return false;

            if (null != _items[v].Find(x=>x.W == w))
                return true;
            return false;
        }
        public List<EdgeV3> GetAdjacentVertex(int i)
        {
            if (i < 0|| i >_numberOfVertex)
                return null;

            return _items[i];
        }        
    }


    //使用邻接矩阵表示带权图，矩阵的值就是权值
    //   2    3    5 
    //2  -  0.5  ..
    //3  .
    //5
    public class WeightedDenseGraph
    {        
        public WeightedDenseGraph(int numberOfVertex, bool isDirected)
        {
        }
    }
}