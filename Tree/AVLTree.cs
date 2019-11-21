using System;
using System.Collections;
using System.Collections.Generic;

namespace AlgorithmPractice {

    public class TAvlNode<TKey, TValue> {
        public TKey Key;
        public TValue Value;
        public int Height;

        public TAvlNode<TKey, TValue> Left;
        public TAvlNode<TKey, TValue> Right;
        public TAvlNode (TKey key, TValue value) {
            this.Key = key;
            this.Value = value;
            Height = 1;
        }
        public TAvlNode (TAvlNode<TKey, TValue> node) {
            Key = node.Key;
            Value = node.Value;
            Height = 1;
        }

        public int GetBalanceFactor()
        {
            if (Left != null && Right != null)
                return Left.Height - Right.Height;
            else if (Left == null)
                return -1 * Right.Height;
            else
            {
                //right is null
                return Left.Height;
            }
        }
    }

    public class AVLTree {
        private TAvlNode<int, int> _root;
        public AVLTree (TAvlNode<int, int> root) {
            _root = root;
        }

        public void Add (int key, int value) {
            _root = _Add (_root, key, value);
        }

        private TAvlNode<int, int> _Add (TAvlNode<int, int> curNode, int key, int value) {
            if (curNode == null)
            {
                var newNode = new TAvlNode<int, int> (key, value);
                newNode.Height = 1;
                return newNode;
            }                

            if (key < curNode.Key)
            {
                curNode.Left = _Add (curNode.Left, key, value);
                curNode.Height ++;
            }                
            else if (key > curNode.Key)
            {
                curNode.Right = _Add (curNode.Right, key, value);
                curNode.Height ++;
            }                
            else {
                //curNode.Key == key;
                curNode.Value = value;
            }

            //Rotate if node now becomes unbalanced.
            var factor = curNode.GetBalanceFactor();
            if (factor > 1 && curNode.Left != null && curNode.Left.GetBalanceFactor() > 1)
            {
                //LL
            }
            if (factor < 0 && curNode.Right != null && curNode.Right.GetBalanceFactor() > 1)
            {
                //RR
            }
            if (factor > 1 && curNode.Left != null && curNode.Right.GetBalanceFactor() > 1)
            {
                //LR
            }
            if (factor < 0 && curNode.Right != null && curNode.Left.GetBalanceFactor() > 1)
            {
                //RL
            }


            return curNode;
        }

        public bool IsBST () {
            //中序遍历二叉搜索树，得到的应该是一个排了序的结果 
            //所以只需要判断遍历结果是否有序就可以了
            var result = new List<int> ();
            InOrder (_root, ref result);

            for (int i = 0; i < result.Count - 1; i++) {
                if (result[i] > result[i + 1])
                    return false;
            }
            return true;
        }

        private void InOrder (TAvlNode<int, int> node, ref List<int> result) {
            if (node == null)
                return;

            InOrder (node.Left, ref result);
            result.Add (node.Key);
            InOrder (node.Right, ref result);
        }

        //红黑树也是一种平衡二叉树，它的平均复杂度虽然都是O(nlogn)，但在维护的时候旋转操作更少，所以更优.
        public bool IsBalanced () {
            return _IsBalanced(_root);
        }

        private bool _IsBalanced(TAvlNode<int, int> node)
        {
            if (node == null)
                return true;
            
            if (Math.Abs(node.GetBalanceFactor()) > 1)
                return false;
            else
                return _IsBalanced(node.Left) && _IsBalanced(node.Right);
        }

    }
}