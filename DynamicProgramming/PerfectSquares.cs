using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;

namespace AlgorithmPractice.DynamicProgramming {

    public class PerfectSquares
    {
        //寻找最小的平方数
        public int numSquares(int n)
        {
            int[] f = new int[n + 1];
            f[0] = 0;
            int i, j;

            for (i = 1; i <= n; i++)
            {
                for (j = 1; j <= i; j++)
                {
                    if (f[i - j * j] + 1 < f[i])
                        f[i] = f[i - j * j] + 1;
                }
            }

            return f[n];
        }











        // private int[] _memo;

        // public int NumSquares(int n)
        // {
        //     _memo = Enumerable.Repeat(-1,n+1).ToArray();
        //     return GetNumSquares(n);
        // }
        //
        //
        // //Wrong
        // private int GetNumSquares(int n)
        // {
        //     if (n <= 1)
        //         return 0;
        //
        //     if (_memo[n] != -1)
        //         return _memo[n];
        //
        //     int number = int.MaxValue;
        //     for(int i=1; i*i<=n; i++)
        //     {                   
        //        number = Math.Min(number, 1 + GetNumSquares(n-i*i));
        //     }
        //
        //     _memo[n] = number;
        //     return number;
        // }       

    }

}