using System;
using System.Collections;
using System.Collections.Generic;

namespace AlgorithmPractice
{
    public class TreeNode{
        public int value;
        public TreeNode left;
        public TreeNode right;
        public TreeNode(int value)
        {
            this.value = value;
        }
        public TreeNode(int value, TreeNode left, TreeNode right){
            this.value = value;
            this.left = left;
            this.right = right;
        }
    }

    public class TreeGenerator{
        public TreeNode Generate(){
            //       2
            //    3       5
            //  7   8   6   4
            var rootNode = new TreeNode(2);
            rootNode.left = new TreeNode(3);
            rootNode.right = new TreeNode(5);

            rootNode.left.left = new TreeNode(7);
            rootNode.left.right = new TreeNode(8);

            rootNode.right.left = new TreeNode(6);
            rootNode.right.right = new TreeNode(4);

            return rootNode;
        }
    }


    public class FindSum{
        public void FindSumPath(TreeNode node, int target, List<List<TreeNode>> nodePaths, List<TreeNode> nodePath)
        {            
            if (node == null)
                return;

            nodePath.Add(node);
            if (node.value == target && node.left == null && node.right== null)
            {
                nodePaths.Add(new List<TreeNode>(nodePath));
                return;
            }               

            FindSumPath(node.left, target - node.value, nodePaths, nodePath);
            if (node.left != null)
                nodePath.RemoveAt(nodePath.Count - 1);
            FindSumPath(node.right, target - node.value, nodePaths, nodePath);
            if (node.right != null)
                nodePath.RemoveAt(nodePath.Count - 1);
            
            return;
        }
    }
}