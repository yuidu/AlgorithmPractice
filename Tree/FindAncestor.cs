using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmPractice.Tree
{
    class FindAncestor
    {
        private TreeNode FindCommonAncestor(TreeNode node, TreeNode c1, TreeNode c2)
        {
            if (node == null)
                return null;
            if (node == c1 || node == c2)
                return node;

            var left = FindCommonAncestor(node.left, c1, c2);
            var right = FindCommonAncestor(node.right, c1, c2);
            if (left != null && right != null)
                return node;

            return (left != null)? left: right;
        }



    }
}
