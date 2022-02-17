using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmPractice.matrix
{
    class NumberOfOneSquares
    {
        //leetcode 1277 统计全为1的正方形的子矩阵
        //给你一个 m * n 的矩阵，矩阵中的元素不是 0 就是 1，
        //请你统计并返回其中完全由 1 组成的 正方形 子矩阵的个数。
        // int countSquares(vector<vector<int>>& matrix)
        // {
        //     int row = matrix.size();
        //     int col = matrix[0].size();
        //     int res = 0;
        //     vector<vector<int>> dp(row+1,vector<int>(col + 1, 0));
        //     for (int i = 0; i < row; i++)
        //     {
        //         for (int j = 0; j < col; j++)
        //         {
        //             if (matrix[i][j] == 1)
        //             {
        //                 dp[i + 1][j + 1] = min(dp[i][j], min(dp[i][j + 1], dp[i + 1][j])) + 1;
        //                 res += dp[i + 1][j + 1];
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
