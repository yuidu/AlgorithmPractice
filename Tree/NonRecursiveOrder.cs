using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmPractice.Tree
{
    class NonRecursiveOrder
    {
        public enum CommandType
        {
            Go,
            Print
        }
        public class Command
        {
            public TreeNode Node { get; set; }
            public CommandType CommandType { get; set; }
            
            public Command(TreeNode node, CommandType commandType)
            {
                Node = node;
                CommandType = commandType;
            }
        }

        //这种模拟栈的非递归算法可以容易地更改为中序和后序遍历。
        public List<TreeNode> PreOrder(TreeNode node)
        {
            if (node == null)
                return null;

            var res = new List<TreeNode>();
            var stack = new Stack<Command>();

            stack.Push(new Command(node.right,CommandType.Go));
            stack.Push(new Command(node.left, CommandType.Go));
            stack.Push(new Command(node, CommandType.Print));

            while (stack.Count != 0)
            {
                var command = stack.Pop();
                if (command.CommandType == CommandType.Print)
                    res.Add(command.Node);
                else if (command.CommandType == CommandType.Go)
                {
                    if (command.Node.right != null)
                        stack.Push(new Command(command.Node.right, CommandType.Go));
                    if (command.Node.left != null)
                        stack.Push(new Command(command.Node.left, CommandType.Go));

                    stack.Push(new Command(command.Node, CommandType.Print));
                }
            }

            return res;
        }
    }
}
