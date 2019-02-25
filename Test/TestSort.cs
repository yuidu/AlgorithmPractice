using System;
using System.Collections.Generic;

namespace AlgorithmPractice
{
    public class TestSort
    {
        public static void Test()
        {
            //TestFindSumPath();
            //TestSelectionSort();         
            //TestInsertionSort();  
            //TestMergeSort();
            //TestQuickSort();
            TestHeapSort();
        }

        private static void TestHeapSort()
        {
            var randoms = RandomArrayGenerator.Generate(10, 0, 30);
            //new HeapSort().Sort(randoms);
            //new HeapSort().Sort2(randoms);
            new HeapSort().Sort3(randoms);  //原地堆排序
            randoms.ForEach(x=>Console.Write(x.ToString() + ','));
        }

        private static void TestQuickSort()
        {
            var randoms = RandomArrayGenerator.Generate(10, 0, 30);
            new QuickSort().Sort(randoms);
            randoms.ForEach(x=>Console.Write(x.ToString() + ','));
        }

        private static void TestMergeSort()
        {
            var randoms = RandomArrayGenerator.Generate(1000, 0, 1000);
            new MergeSort().Sort(randoms);
            randoms.ForEach(x=>Console.Write(x.ToString() + ','));
            // var bSorted = SortHelper.IsSorted(randoms);
            // if (bSorted)
            //     Console.WriteLine("sorting successful");
            // else
            //     Console.WriteLine("sorting unsuccessful");
        }


        private static void TestSelectionSort()
        {
            var randoms = RandomArrayGenerator.Generate(1000, 0, 1000);
            new SelectionSorting().Sort2(randoms);
            //randoms.ForEach(x=>Console.Write(x.ToString() + ','));
            var bSorted = SortHelper.IsSorted(randoms);
            if (bSorted)
                Console.WriteLine("sorting successful");
            else
                Console.WriteLine("sorting unsuccessful");
        }

        private static void TestInsertionSort()
        {
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

            nodePaths.ForEach(x =>
            {
                x.ForEach(
                    y =>
                    {
                        Console.Write(y.value);
                    });
                Console.WriteLine("");
            });
        }
    }
}