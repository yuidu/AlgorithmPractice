using System;
using System.Collections;
using System.Collections.Generic;

//二分搜索树主要解决搜索问题，因为该树可以以O(nlogn)的复杂度解决查找插入删除
//主要用于字典表有key 和value的查找
//二分搜索树的性质是当前结点大于左孩子小于右孩子

namespace AlgorithmPractice {
    public class TNode<TKey, TValue> {
        public TKey Key;
        public TValue Value;

        public TNode<TKey, TValue> Left;
        public TNode<TKey, TValue> Right;
        public TNode (TKey key, TValue value) {
            this.Key = key;
            this.Value = value;
        }
        public TNode(TNode<TKey,TValue> node)
        {
            Key = node.Key;
            Value = node.Value;
        }
    }

    public class BST<TKey,TValue> {
        TNode<int,int> _root;
        public void Insert(int key, int value)
        {
            _root = Insert(_root, key, value);
        }

        //如果结点相同则为更新操作
        //返回新的根结点
        //todo: 写一个非递归算法 
        private TNode<int, int> Insert (TNode<int, int> node, int key, int value) {
            if (node == null)
                return new TNode<int, int>(key, value);

            if (key > node.Key)
                node.Left = Insert (node.Left, key, value);
            else if (key < node.Key)
                node.Right = Insert (node.Right, key, value);
            else
            {
                node.Value = value;
            }
            return node;
        }

        //查找和insert的算法逻辑相似
        //Contains和Search也类似
        public bool Contains(int key)
        {
            return Contains(_root, key);            
        }

        private bool Contains(TNode<int, int> node, int key)
        {
            if (node == null)
                return false;

            if (node.Key == key)
                return true;
            else if (key < node.Key)
                return Contains(node.Left, key);
            else 
                return Contains(node.Right, key);
        }

        public int? Search(int key)
        {
            return Search(_root, key);
        }

        private int? Search(TNode<int,int> node, int key)
        {
            if(node == null)
                return null;

            if (node.Key == key)            
                return node.Value;
            else if (key < node.Key)
                return Search(node.Left, key);
            else
                return Search(node.Right, key);
        }

        //中序遍历二分搜索树就是从小到大的顺序
        //后序遍历用在如释放二叉树的时候，先把子结点释放再释放父亲结点
        public void PreOrder(TNode<int,int> node)
        {
            Console.Write(node.Value);
            PreOrder(node.Left);
            PreOrder(node.Right);
        }

        public void InOrder(TNode<int,int> node)
        {
            InOrder(node.Left);
            Console.Write(node.Value);
            InOrder(node.Right);
        }

        public void PostOrder(TNode<int,int> node)
        {
            PostOrder(node.Left);
            PostOrder(node.Right);
            Console.Write(node.Value);
        }

        public void Dispose()
        {
            Remove(_root);
        }

        //后序遍历通常用来翻放空间，因为先操作两个子节点再操作自身结点
        private void Remove(TNode<int, int> node)
        {
            Remove(node.Left);
            Remove(node.Right);
            node = null;
        }

        //层序遍历
        //每种遍历方式的时间复杂(O(n))，是非常高效的        
        public void LevelOrder()
        {
            LevelOrder(_root);
        }

        private void LevelOrder(TNode<int, int> node)
        {
            var q = new Queue();
            q.Enqueue(node);
            while(q.Count > 0)
            {
                var cur = q.Dequeue() as TNode<int,int>;
                //print cur

                if (cur.Left != null)
                    q.Enqueue(cur.Left);
                if (cur.Right != null)
                    q.Enqueue(cur.Right);
            }

        }

        //最左边的叶子结点就是最小值，最右边的叶子结点就是最大值
        public int Min()
        {
            var cur = _root;
            var lastLeaf  = _root;
            while(cur != null)
            {
                lastLeaf = cur;
                cur = cur.Left;                
            }

            return lastLeaf.Value;
        }

        //递归版本的查找最小值
        public TNode<int,int> Minimum()
        {
            return Minimum(_root);
        }
        // private int Minimum(TNode<int, int> node)
        // {
        //     if (node.Left == null)
        //         return node.Value;
        //     else
        //         return Minimum(node.Left);
        // }

        private TNode<int,int> Minimum(TNode<int, int> node)
        {
            if (node.Left == null)
                return node;
            else
                return Minimum(node.Left);
        }

        //递归版本的最大值
        private int Maximum(TNode<int,int> node)
        {
            if(node.Right == null)
                return node.Value;
            else
                return Maximum(node.Right);
        }

       //删除最小值
        private void RemoveMin()
        {
            _root = RemoveMin(_root);
        }

        private TNode<int,int> RemoveMin(TNode<int,int> node)
        {
            if (node.Left == null)
            {
                if (node.Right == null)
                {
                    node = null;
                    return node;
                }
                else
                {   
                    return node.Right;
                }
            }

            node.Left = RemoveMin(node.Left);
            return node;
        }
        //5-7, 试着用递归实现
        private void RemoveMax()
        {}

        //Hubbard deletion
        //当删除一个有左右孩 子的结点时，要选一个结点要代替当前结点，这个结点就是右子树的小最值
        private void Remove(int key)
        {
            _root = Remove(_root,key);
        }

        private TNode<int,int> Remove(TNode<int,int> node, int key)
        {
            if (node.Key == key) 
            {
                //如果没有左孩子，两种情况，有右孩子或为空，都只需将右孩子（或空）替换该结点
                if (node.Left == null)
                {
                    return node.Right;
                }
                if (node.Right == null)
                {
                    return node.Left;
                }
                
                //左右孩子均不为空,将当前结点右子树的最小值替换当前结点，或者当前结点左子树的最大值替换当前结点。
                var minNode = new TNode<int,int>(Minimum(node.Right));
                var newRoot = RemoveMin(node.Right);
                minNode.Right = newRoot;
                minNode.Left = node.Left;
                return minNode;
            }  
            else if (key < node.Key)
            {
                node.Left = Remove(node.Left, key);
            }
            else
            {
                node.Right = Remove(node.Right,key);
            }
            return node;
        }

        //二分搜索树能回答顺序问题
        //min,max
        //successor, pre  找前驱后继(某个结点左子树最大值就是前驱，右子树的最小就是后继)
        //floor, ceil
        //rank  58是排名第几的元素？ (每个结点多存储一个rank，rank是这个结点为根的树的结点数)
        //select 排名第10的元素是谁？
        //支持重复元素的二分搜索树 
        //(方法1：把左孩子定义为小于等于该结点)
        //（方法2： 把每个结点加一个count表明相同结点的数量,remove,insert都要相应的进行更改）
        
        
        //二分搜索树的局限性
        //同样的数据对应不同的二分搜索树
        //如果用之前的算法insert一个有序的元素123456，会变成一个链表，那样插入删除复杂度就会变成o(n)而不是(logn)
        //解决方法一，如果数据能一次拿到，利用类似快排的方法，插入的

        //平衡二叉树，左右子数的高度差不超过一
        //红黑树是一种平衡二叉树
        //还有2-3tree AVL tree, splay tree（伸展树）

        //平衡二叉树和堆的结合：Treap，保持了两种结果的特性

        //Trie
        //查找一个字典，只需要花查找单词的数量的时间
        // start
        // a  d  n  z
        //r s o   
        //e
        //用Trie来统计词频


        //树形问题
        //1. 递归法天然的树形的性质
        //搜索问题（下棋，八皇后，等）


    }
}