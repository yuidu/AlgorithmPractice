using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmPractice.DynamicProgramming
{
    class CoinChange_lint669
    {
        /// <summary>
        /// You are given coins of different denominations and a total amount of money amount.
        /// Write a function to compute the fewest number of coins that you need to make up that amount.
        /// If that amount of money cannot be made up by any combination of the coins, return -1.
        /// </summary>
        /// <param name="coins"></param>
        /// <param name="amount"></param>
        /// <returns></returns>
        public int coinChange(int[] coins, int amount)
        {
            // write your code here
            if (amount == 0)
                return 0;

            int w = amount;
            int n = coins.Length;

            int[] f = new int[w + 1];
            f[0] = 0;
            for (int i = 1; i <= w; i++)
            {
                f[i] = int.MaxValue;
                for (int j = 0; j < n; j++)
                {
                    if (i - coins[j] >= 0 && f[i - coins[j]] != int.MaxValue)
                        f[i] = Math.Min(f[i], f[i - coins[j]] + 1);
                }
            }

            if (f[w] == int.MaxValue)
                return -1;

            return f[w];
        }
    }
}
