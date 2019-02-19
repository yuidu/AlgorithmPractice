using System;
using System.Collections.Generic;

namespace AlgorithmPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");
            TreeGenerator generator = new TreeGenerator();
            TreeNode root = generator.Generate();

            List<List<TreeNode>> nodePaths = new List<List<TreeNode>>();
            List<TreeNode> nodePath = new List<TreeNode>();
            new FindSum().FindSumPath(root, 11, nodePaths, nodePath);

            nodePaths.ForEach(x=>{
                x.ForEach(
                    y=>{
                    Console.Write(y.value);
                    });
                Console.WriteLine("");
            });            
        }
    }
}
