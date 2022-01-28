using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmPractice.matrix
{
    class rob3
    {
        public int rob(TreeNode root)
        {
            IDictionary<TreeNode, int> memo = new Dictionary<TreeNode, int>();
            return robInternal(root, memo);
        }

        public int robInternal(TreeNode root, IDictionary<TreeNode, int> memo)
        {
            if (root == null) return 0;
            if (memo.ContainsKey(root)) return memo[root];
            int money = root.value;

            if (root.left != null)
            {
                money += (robInternal(root.left.left, memo) + robInternal(root.left.right, memo));
            }

            if (root.right != null)
            {
                money += (robInternal(root.right.left, memo) + robInternal(root.right.right, memo));
            }

            int result = Math.Max(money, robInternal(root.left, memo) + robInternal(root.right, memo));
            memo.Add(root, result);
            return result;
        }

        //动规
        // public int rob(TreeNode root)
        // {
        //     int[] result = robInternal(root);
        //     return Math.max(result[0], result[1]);
        // }
        //
        // public int[] robInternal(TreeNode root)
        // {
        //     if (root == null) return new int[2];
        //     int[] result = new int[2];
        //
        //     int[] left = robInternal(root.left);
        //     int[] right = robInternal(root.right);
        //
        //     result[0] = Math.max(left[0], left[1]) + Math.max(right[0], right[1]);
        //     result[1] = left[0] + right[0] + root.val;
        //
        //     return result;
        // }
        //

    }
}
