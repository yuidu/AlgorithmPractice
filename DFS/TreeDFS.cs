using System;
using System.Collections.Generic;
using System.Collections;

namespace AlgorithmPractice {
    public class TreeNodeV3
    {
        public TreeNodeV3 Left;
        public TreeNodeV3 Right;
        public int Value;
        public TreeNodeV3(int value)
        {
            Value = value;
        }
    }
    public class TreeDFS
    {                
        //Leet code 104:
        public int GetDepth(TreeNodeV3 node)
        {
            if (node == null)
                return 0;            

            return Math.Max(GetDepth(node.Left),GetDepth(node.Right)) + 1;
        }

        public int IsSameTree(TreeNodeV3 node)
        {
            
        }
    }
}