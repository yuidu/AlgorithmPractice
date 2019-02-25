using System;
using System.Collections;
using System.Collections.Generic;

namespace AlgorithmPractice
{
    public class Component
    {
        private int componentCount;
        private List<bool> isVisisted;
        private IGraph graph;

        public List<int> linkedComponent;
        public Component(IGraph graph)
        {
            this.graph = graph;
            var vCount = graph.V();
            componentCount = 0;
            linkedComponent = new List<int>();
            isVisisted = new List<bool>(14);
            for(int i=0; i<14; i++)
            {
                isVisisted.Add(false);
                linkedComponent.Add(-1);
            }
                

            for(int i=0; i<vCount; i++)
            {
                if (!isVisisted[i])
                {
                    componentCount++;
                    Dfs(i);                    
                }
                    
            }
        }

        private void Dfs(int v)
        {
            isVisisted[v] = true;
            linkedComponent[v] = componentCount;
            var vs = graph.GetAdjacentVertexes(v);
            for(int i=0; i<vs.Count; i++)
            {
                if (!isVisisted[vs[i]])
                {
                    Dfs(vs[i]);
                    linkedComponent[vs[i]] = componentCount;
                }                    
            }
        }

        public bool HasPath(int v, int w)
        {
            return linkedComponent[v] == linkedComponent[w];
        }


        //多少个连通分量
        public int GetComponent()
        {
            return componentCount;
        }
    }
}