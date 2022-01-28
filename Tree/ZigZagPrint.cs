using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmPractice.Tree
{
    public class ZigZagPrint
    {
        public void Test()
        {
            //[1,2,3,4,null,null,5]

            var n1 = new TreeNode(1);
            var n2 = new TreeNode(2);
            var n3 = new TreeNode(3);
            var n4 = new TreeNode(4); 
            var n5 = new TreeNode(5);

            n1.left = n2;
            n1.right = n3;
            n2.left = n4;
            n3.right = n5;
            var result = PrintZigzag(n1);
        }

        public IList<IList<int>> PrintZigzag(TreeNode root)
        {
            if (root == null)
                return new List<IList<int>>();

            return print(root);
        }

        public class PrintNode
        {
            public TreeNode Node;
            public int Level;

            public PrintNode(TreeNode node, int level)
            {
                Node = node;
                Level = level;
            }
        }

        private IList<IList<int>> print(TreeNode node)
        {
            var pN = new PrintNode(node, 1);
            Queue<PrintNode> q = new Queue<PrintNode>();
            q.Enqueue(pN);

            var res = new List<IList<int>>();
            var preLevel = -1;
            var cur = new List<int>();
            while (q.Count != 0)
            {
                var e = q.Dequeue();
                if (preLevel != e.Level)
                {
                    cur = new List<int>();
                    res.Add(cur);
                    preLevel = e.Level;
                }
                cur.Add(e.Node.value);

                if (e.Level % 2 == 0)
                {
                    if (e.Node.left != null)
                        q.Enqueue(new PrintNode(e.Node.left, e.Level + 1));
                    if (e.Node.right != null)
                        q.Enqueue(new PrintNode(e.Node.right, e.Level + 1));
                }
                else //print from right to left.
                {
                    if (e.Node.right != null)
                        q.Enqueue(new PrintNode(e.Node.right, e.Level + 1));
                    if (e.Node.left != null)
                        q.Enqueue(new PrintNode(e.Node.left, e.Level + 1));
                }
            }

            return res;
        }
    }
}
