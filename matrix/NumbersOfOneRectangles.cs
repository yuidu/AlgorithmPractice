using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmPractice.matrix
{
    class NumbersOfOneRectangles
    {
        //leetcode 1504 统计全为1的子矩形
        //给你一个只包含 0 和 1 的 rows * columns 矩阵 mat ，请你返回有多少个 子矩形 的元素全部都是 1 。
        // int numSubmat(vector<vector<int>>& mat)
        // {
        //     int n = mat.size();
        //     int m = mat[0].size();
        //     vector<vector<int>> dp(n, vector<int>(m,0));
        //     for (int i = 0; i < n; i++)
        //     {
        //         for (int j = 0; j < m; j++)
        //         {
        //             if (j == 0)
        //             {
        //                 dp[i][j] = mat[i][j];
        //             }
        //             else if (mat[i][j])
        //             {
        //                 dp[i][j] = dp[i][j - 1] + 1;
        //             }
        //             else
        //             {
        //                 dp[i][j] = 0;
        //             }
        //         }
        //     }
        //     int res = 0;
        //     for (int i = 0; i < n; i++)
        //     {
        //         for (int j = 0; j < m; j++)
        //         {
        //             int temp = dp[i][j];
        //             for (int k = i; k >= 0; k--)
        //             {
        //                 temp = min(temp, dp[k][j]);
        //                 res += temp;
        //             }
        //         }
        //     }
        //     return res;
        // }
        // ————————————————
        // 版权声明：本文为CSDN博主「peachzy」的原创文章，遵循CC 4.0 BY-SA版权协议，转载请附上原文出处链接及本声明。
        // 原文链接：https://blog.csdn.net/peachzy/article/details/114679993
    }
}
