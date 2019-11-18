using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
namespace AlgorithmPractice.LeetCode
{
    public class TreeRelated
    {
        //LC104
        public int GetMaxDepth(LCTreeNode node)
        {
            if (node == null)
                return 0;

            return Math.Max(GetMaxDepth(node.Left),
            GetMaxDepth(node.Right)) + 1;
        }

        //todo: 实现有问题 LC111
        public int GetMinDepth(LCTreeNode node)
        {   
            if (node == null)
                return 0;
            if (node.Left == null && node.Right == null)
                return 1;

            return Math.Min(GetMinDepth(node.Left),
            GetMinDepth(node.Right)) + 1;
        }

    }
}
