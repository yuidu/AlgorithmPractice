using System;
using System.Collections.Generic;

namespace AlgorithmPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            //TestFindSumPath();
            //TestSelectionSort();         
            TestInsertionSort();  
        }

        private static void TestSelectionSort(){
            var randoms = RandomArrayGenerator.Generate(1000, 0, 1000);
            new SelectionSorting().Sort2(randoms);
            //randoms.ForEach(x=>Console.Write(x.ToString() + ','));
            var bSorted = SortHelper.IsSorted(randoms);
            if (bSorted)
                Console.WriteLine("sorting successful");
            else 
                Console.WriteLine("sorting unsuccessful");
        }

       private static void TestInsertionSort(){
            var randoms = RandomArrayGenerator.Generate(1000, 0, 1000);
            //new InsertionSort().Sort(randoms);
            new InsertionSort().Sort2(randoms);
            //randoms.ForEach(x=>Console.Write(x.ToString() + ','));
            var bSorted = SortHelper.IsSorted(randoms);
            if (bSorted)
                Console.WriteLine("sorting successful");
            else 
                Console.WriteLine("sorting unsuccessful");
        }


        private void TestFindSumPath()
        {
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
