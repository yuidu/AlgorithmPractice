using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.DP
{
    class fibnacci
    {
        private int[] memo;

        fibnacci()
        {
           
        }

        public int fibnacci1(int n)
        {
            if (n == 0)
                return 0;
            if (n == 1)
                return 1;
            if (memo[n] == -1)
                memo[n] = fib1(n - 1) + fib1(n - 2);
            return memo[n];
        }
        public int fib1(int n)
        {
            memo = Enumerable.Repeat(-1, n).ToArray();
            return fibnacci1(n);
        }

        public int fibDp(int n)
        {
            memo = Enumerable.Repeat(-1, n+1).ToArray();
            memo[0] = 0;
            memo[1] = 1;

            for (int i = 2; i <= n; i++)
            {
                memo[i] = memo[i - 1] + memo[i - 2];
            }

            return memo[n];
        }


    }
}
