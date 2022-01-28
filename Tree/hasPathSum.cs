using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmPractice.Tree
{
    class hasPathSum
    {
        private bool ans;
        public virtual bool haspathSum(Node node, int sum)
        {
            ans = false;

            int subsum = sum - node.data;
            if (subsum == 0 && node.left == null
                            && node.right == null)
            {
                return true;
            }

            /* otherwise check both subtrees */
            if (node.left != null)
            {
                ans = ans || haspathSum(node.left, subsum);
            }
            if (node.right != null)
            {
                ans = ans || haspathSum(node.right, subsum);
            }
            return ans;

        }
    }
}
