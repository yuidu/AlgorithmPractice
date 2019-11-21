using System;
using System.Collections;
using System.Collections.Generic;

namespace AlgorithmPractice {

    public class TAvlNode<TKey, TValue> {
        public TKey Key;
        public TValue Value;
        public int Height;

        public TNode<TKey, TValue> Left;
        public TNode<TKey, TValue> Right;
        public TAvlNode (TKey key, TValue value) {
            this.Key = key;
            this.Value = value;
            Height = 1;
        }
        public TAvlNode(TNode<TKey,TValue> node)
        {
            Key = node.Key;
            Value = node.Value;
            Height = 1;
        }
    
    }

  public class AVLTree
  {
      private TAvlNode<int,int> _root;
      public AVLTree(TAvlNode<int,int> root)
      {
          _root = root;
      }

      public void Add(TAvlNode<int,int> node)
      {

      }

      public bool IsBST()
      {
          //中序遍列二叉搜索树，得到的应该是一个排了序的结果 
          //所以只需要判断遍历结果是否有序就可以了

      }

      //红黑树也是一种平衡二叉树，它的平均复杂度虽然都是O(nlogn)，但在维护的时候旋转操作更少，所以更优.
      

      public bool IsBalanced()
      {


      }
      
  }
}