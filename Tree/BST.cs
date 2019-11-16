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
            
        }

        //层序遍历
        //每种遍历方式的时间复杂(O(n))，是非常高效的        
        public void LevelOrder()
        {

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

        private void RemoveMin()
        {}

        //5-7, 试着用递归实现
        private void RemoveMax()
        {}

        //Hubbard deletion
        //当删除一个有左右孩 子的结点时，要选一个结点要代替当前结点，这个结点就是右子树的小最值
        private void Remove(int key)
        {
            
        }

    }
}