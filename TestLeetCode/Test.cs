using System;
using System.Collections.Generic;

namespace AlgorithmPractice
{

    public class TestLeetCode
    {
        public static void Test()
        {
            //TestNo3();
            TestNo5();
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