using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode
{
    class _1235_MostProfit
    {
        public int JobScheduling(int[] startTime, int[] endTime, int[] profit)
        {
            //首先将开始时间，结束时间，收益结合成3元组，然后按照区间结束时间排序
            var sort = startTime.Zip(endTime, (a, b) => (start: a, end: b))
                .Zip(profit, (a, b) => (a.start, a.end, cost: b))
                .OrderBy(e => e.end).ToArray();
            var n = startTime.Length;

            //构建一个预处理数组。记录若选择第i个区间（i从0开始），memo[i] = k,表示排序后1开始到第i个区间中与i区间不冲突的区间数。
            var memo = new int[n + 1];
            memo[1] = 0;

            for (var i = 2; i <= n; i++)
            {
                var j = i - 1; //指针初始化为当前区间前一个位置
                while (j >= 1)
                {
                    //如果不存在冲突,那么前1到j（包含j)个区间都不和i区间冲突，直接记录，然后break
                    if (sort[j - 1].end <= sort[i - 1].start)
                    {
                        memo[i] = j;
                        break;
                    }
                    j--;
                }
            }

            var dp = new int[n + 1];
            dp[1] = sort[0].cost; //dp[i]表示选择前i个区间的最大收益。dp[0] = 0
            for (var i = 2; i <= n; i++)
            {
                var pre = memo[i]; //根据预处理的数组，找出如果选择第i个区间，那么就只能选前多少个区间。
                //选择第i或者不选 max(选择i的情况: dp[pre] + sort[i - 1].cost, 不选择i区间: dp[i - 1] )
                var max = Math.Max(dp[pre] + sort[i - 1].cost, dp[i - 1]);
                dp[i] = max;
            }
            return dp[n];
        }
    }
}
