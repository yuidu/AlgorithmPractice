using System;
using System.Collections.Generic;

namespace AlgorithmPractice
{
    public class TestOthers
    {
        public static void Test()
        {
            char[,] testInput = {
                {'1','1','1','1','0'},
                {'1','1','0','1','0'},
                {'1','1','0','0','0'},
                {'0','0','0','0','0'}
            };

            var num = new FloodFill().NumIslands(testInput);            
            Console.WriteLine(num);
        }
    }
}