//并查集
//1.解决连接问题，网络中节点间的连接状态
//2. 数学中集合类的实现.
//3. 连接问题和路径问题，从一个节点能不能到达另一个结点。
//   连接问题只需要回答两个结点是否相连。而路径问题需要更多的信息，比路径问题要回答的问题少。
//

//支持两个动作
// union(p,q)
// find(p)
// 回答一个问题
// isConnected(p,q)

using System;
using System.Collections.Generic;

namespace AlgorithmPractice
{

    //Solution 1: QuickFind
    //是否连接会快，但union慢, n个数，每个数union一遍，这样整体复杂度是O(n2)
        public class QuickFind{
        private int[] id;
        private int count;
        public QuickFind(int n)
        {            
            count = n;
            id = new int[n];
            for(int i=0; i<n;i++)
             id[i] = i;
        }
        
        public int Find(int p)
        {
            if (p >=0 && p < count)            
                return id[p];
            return -1;
        }

        public bool isConnected(int p, int q)
        {
            return Find(p) == Find(q);
        }

        public void union(int p, int q)
        {
            int vP = id[p];
            int vQ = id[q];

            if (vP == vQ)
                return;

            for(int i=0; i<count; i++)
            {
                if (id[i] == vP)
                    id[i] = vQ;
            }
        }
    }





    //Solution 2: quick union
    //Element:  0 1 2 3 4 5 6 7
    //Parent:   0 1 2 8 3 5 5 7..
    //每个元素存父亲是哪个元素
    public class QuickUnion
    {
        private int[] parent; //parent's id
        private int count;
        
        //优化1:
        private int[] groupCount;  //存储以该结点为根的结点数量
        private int[] rank;   //存储以该结点为根的树的高度
        public QuickUnion(int n)
        {
            parent = new int[n];
            count = n;
            for(int i=0; i<n; i++)
            {
                parent[i] = i;
                groupCount[i] = 1;
            }
        }

        //return the root of p
        public int Find(int p)
        {
            while(parent[p] != p)
            {
                //优化: Path compression 1
                //路径压缩，每次跑二步
                parent[p] = parent[parent[p]];

                p = parent[p];
            }
                
            return parent[p];
        }

        //优化: Path compression 2 所有子结点都指向根，这样树只有二层
        //这个方法貌似最优，但实际上因为递归的开销，所以实际上并不比优化一好。
        // private int Find(int p)
        // {
        //     if (p != parent[p])
        //         parent[p] = Find(parent[p]);
        //     return parent[p];
        // }

        public bool isConnected(int p, int q)
        {
            return Find(p) == Find(q);
        }

        public void union(int p, int q)
        {
            if (isConnected(p,q))
                return;

            int vP = Find(p);
            int vQ = Find(q);

            //优化 1: 将该结点为根的树结点少的指向结点数多的根。
            //该优化仍有问题，因为结点少并不意味着层数少，结点多也可能层数很小。
            // if (groupCount[vP] < groupCount[vQ])
            // {
            //     parent[vP] = vQ;
            //     groupCount[vQ] += groupCount[vP];
            // }
            // else
            // {
            //     parent[vQ] = vP;
            //     groupCount[vP] += groupCount[vQ];
            // }            

            //优化2： 将树层数少的指向树层数高的
            if (rank[vP] < rank[vQ])
            {
                rank[vP] = vQ;
            }
            else if (rank[vQ] < rank[vP])
            {
                rank[vQ] = vP;
            }
            else // ==
            {
                rank[vP] =  vQ;
                rank[vQ]++;
            }
        }
    }
}