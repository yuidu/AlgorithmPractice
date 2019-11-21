using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
namespace AlgorithmPractice.LeetCode
{
    public class Knapsack
    {

        private int[,] _memo;
        public void GetMaxValue(List<int> w, List<int> value, int knapSackCapacity)
        {
            var n = w.Count;
            _memo = new int[n,knapSackCapacity];
            for(int i=0; i<n; i++)
                for(int j=0; j<knapSackCapacity; j++)
                    _memo[i,j] = -1;
        }


        //index;  当前处理第几件物品
        //c: 当前背包可容纳的总容量
        public int GetMaxValue(List<int> weights, List<int> values, int index, int c)
        {
            if (index < 0)
                return 0;
            
            //记忆化搜索部分
            if (_memo[index,c] != -1)
                return _memo[index,c];

            //每件物品，两个决定，要不要把当前这个物品放进去
            int res = -1;
            //不放这件物品
            res = Math.Max(res, GetMaxValue(weights, values, index -1, c));

            //放这件物品
            if (weights[index] <= c)  //能放进这件物品
                res = Math.Max(res, values[index] + GetMaxValue(weights, values, index-1, c-weights[index]));
            
            _memo[index,c] = res;
            return res;
        }
    }
}