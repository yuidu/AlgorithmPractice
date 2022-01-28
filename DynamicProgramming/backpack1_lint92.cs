using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmPractice.DynamicProgramming
{
    class backpack1_lint92
    {
        //A记录所有物品的重量（大小），背包承重为m, 问能带走的最大重量。
        public int backPack(int m, int[] A)
        {
            // write your code here
            //找到前i个物品能否能拼出0,1,2.....m    
            //f[i][j]: 前i个物品能否拼出重量为j
            //f[i][j] = f[i-1][j] OR f[i-1][j-A[i-1]] | j>A[i-1]   //前i-1个物品就能出j来了， 或者 前i-1个能否拼出j-A[i-1]且在当前能放下j-A[i-1]的情况下

            int n = A.Length;
            if (n == 0)
                return 0;

            bool[][] f = new bool[n + 1][];
            f[0][0] = true;

            for (int j = 1; j <= m; j++)
                f[0][j] = false;    //0个物品不能拼出大于0的重量

            for (int i = 1; i <= n; i++)
            {
                f[i] = new bool[m + 1];
                for (int j = 0; j <= m; j++)
                {
                    f[i][j] = f[i - 1][j];
                    if (j - A[i - 1] >= 0)
                        f[i][j] = f[i][j] || f[i - 1][j - A[i - 1]];
                }
            }

            for (int i = n; i >= 0; i--)
            {
                for (int j = m; j >= 0; j--)
                    if (f[i][j])
                        return j;
            }

            return 0;
        }
    }
}
