using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmPractice.Tree
{
    // Given the root of a binary tree and an integer targetSum, return the number of paths where the sum of the values along the path equals targetSum.
    //
    // The path does not need to start or end at the root or a leaf, but it must go downwards(i.e., traveling only from parent nodes to child nodes).
    //
    class GetSumPath
    {
        public int PathSum(TreeNode root, int targetSum)
        {
            if (root == null)
            {
                return 0;
            }

            int ret = RootSum(root, targetSum);
            ret += PathSum(root.left, targetSum);
            ret += PathSum(root.right, targetSum);
            return ret;
        }

        public int RootSum(TreeNode root, int targetSum)
        {
            int ret = 0;

            if (root == null)
            {
                return 0;
            }
            int val = root.value;
            if (val == targetSum)
            {
                ret++;
            }

            ret += RootSum(root.left, targetSum - val);
            ret += RootSum(root.right, targetSum - val);
            return ret;
        }
    }
}
