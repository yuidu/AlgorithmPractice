using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;

namespace AlgorithmPractice.LeetCode
{
    public class BreakInteger
    {
        //将一个数分为以为这个数为和的两个以上的部分，返回这些划分最大的乘积。
        //第一次循环将n分为1和(n-1)划分的乘积，2和(n-2)划分的乘积,直到n-1和1的乘积
        //在n-1划分的乘积下，寻找1和(n-1)-1的乘积，2和(n-1)-2的乘积...
        //在n-2划分的乘积下，寻找1和(n-2)-1的乘积，2和(n-2)-2...
        //按此逻辑，递归树可以说是穷举了所有的可能性
        public int BreakInt(int n)
        {
            if (n==1)
                return 1;

            var result = 0;
            for(int i=1; i<n; i++)
                result = Math.Max(result, Math.Max(i*(n-i), (i * BreakInt(n-i))));
            
            return result;
        }
    }
    
    
    //引入记忆化搜索，剪掉递归树中的重复分支
    public class BreakIntegerV2
    { 
        private int[] memo;
       
        private int BreakInt(int n)
        {
            if (n==1)
                return 1;
            
            if (memo[n] != -1)
                return memo[n];

            var result = 0;
            for(int i=1; i<n; i++)
                result = Math.Max(result, Math.Max(i*(n-i), (i * BreakInt(n-i))));
            
            memo[n] = result;
            return result;
        }

        public int BreakInteger(int n)
        {
            if ( n < 2)
                throw new Exception();

            memo = Enumerable.Repeat(-1,n+1).ToArray();
            return BreakInt(n);
        }
    }

    public class BreakIntegerV3
    {
        public int BreakInteger(int n)
        {
            var memo = Enumerable.Repeat(-1, n+1).ToArray();
            
            for(int i=1; i< n; i++)
                for(int j=1; j<i; j++)
                    memo[i] = Math.Max(j*(i-j), memo[i-j]);

            return memo[n];
        }

    }
}