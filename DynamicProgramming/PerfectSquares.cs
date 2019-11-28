using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace AlgorithmPractice.DynamicProgramming {

    public class PerfectSquares
    {

        private int[] _memo;
        //寻找最小的平方数
        public int NumSquares(int n)
        {
            _memo = Enumerable.Repeat(-1,n+1).ToArray();
            return GetNumSquares(n);
        }
        

        //Wrong
        private int GetNumSquares(int n)
        {
            if (n <= 1)
                return 0;

            if (_memo[n] != -1)
                return _memo[n];

            int number = int.MaxValue;
            for(int i=1; i*i<=n; i++)
            {                   
               number = Math.Min(number, 1 + GetNumSquares(n-i*i));
            }

            _memo[n] = number;
            return number;
        }       

    }

}