using System;
using System.Collections.Generic;
using AlgorithmPractice.LeetCode;

namespace AlgorithmPractice
{
    public class TestLeetCode
    {
        public static void Test()
        {
            //TestNo3();
            //TestNo5();
            //TestNo347();
            TestNo257();
        }


    private static void TestNo257()
    {
        //      5
        //    2   3
        //  1  8    4
        //  7
        //expected result:  5->2->1->7, 5->2->8, 5->3->4

        var root = new LCTreeNode(5);
        root.Left = new LCTreeNode(2);
        root.Right = new LCTreeNode(3);

        root.Left.Left = new LCTreeNode(1);
        root.Left.Right = new LCTreeNode(8);

        root.Right.Right = new LCTreeNode(4);
        root.Left.Left.Left = new LCTreeNode(7);

        var returnPaths = new ReturnAllPaths();
        var paths = returnPaths.GetAllPaths(root);
        paths.ForEach(x=>Console.WriteLine(x));
    }
    private static void TestNo347()
    {
        //top 5:  22,8,72,45,88
        //         8,7, 5, 4, 4 
        var testElements = new List<int>{
            23,72,62,63,75,86,8,
            11,44,45,77,88,8,22,
            123,328,348,88,11,23,72,
            22,8,72,23,8,565,88,
            45,45,8,22,88,232,
            22,89,22,8,22,72,77,22,8,80,2,8,33,72,45,80,76,26,80
        };

        // //5: 4, 6: 3
        // var testElements = new List<int>{
        //     5,6,7,5,5,2,8,5,6,6
        // };
        var topKfreq = new TopKFrequency();
        var topKelements = topKfreq.GetTopKFrequency(testElements, 5);
        Console.WriteLine(string.Join(',',topKelements));
    }


    private static void TestNo2()
    {
            ListNode l1 = new ListNode(2);
            l1.next = new ListNode(4);
            l1.next.next = new ListNode(3);


            ListNode l2 = new ListNode(5);
            l2.next = new ListNode(6);
            l2.next.next = new ListNode(4);


            var lt = new AddTwoNumbersCL().AddTwoNumbers(l1,l2);

    }


    private static void TestNo3()
    {
        var ret = new LengthOfLongestSubstringLC().LengthOfLongestSubstring("pwwkew");
        Console.WriteLine("Expected: 3, Actual: " +ret);

        var ret2 = new LengthOfLongestSubstringLC().LengthOfLongestSubstring_2("pwwkew");
        Console.WriteLine("Expected: 3, Actual: " +ret2);
    }

    private static void TestNo5()
    {
        var output = new LongestPalindromic().LongestPalindrome("cbbd");
        Console.WriteLine(output);
    }
    }
}