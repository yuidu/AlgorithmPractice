using System;
using System.Collections.Generic;

namespace AlgorithmPractice
{
    public class TestSearch{
        public static void Test()
        {
            TestBinarySearch();
        }
        public static void TestBinarySearch()
        {
            var data = new List<int>(){1,2,3,4,5,6,7,8,9,10};
            var ret = new BinarySearch().Search(data, 7);
            if (ret == 6)
                Console.WriteLine("Found successfully!");
            else
                Console.WriteLine("Found unsuccessfully!");
        }
    }
}