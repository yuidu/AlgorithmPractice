using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmPractice.matrix
{
    class TargetSum
    {
        //leetcode 1074 元素和为目标值的子矩阵数量
        //给出矩阵 matrix 和目标值 target，返回元素总和等于目标值的非空子矩阵的数量。

        // int numSubmatrixSumTarget(vector<vector<int>>& matrix, int target)
        // {
        //     int row = matrix.size();
        //     int col = matrix[0].size();
        //     int res = 0;
        //     for (int i = 0; i < row; i++)
        //     {
        //         vector<int> sum(col,0);
        //         for (int j = i; j >= 0; j--)
        //         {
        //             for (int k = 0; k < col; k++)
        //             {
        //                 sum[k] += matrix[j][k];
        //             }
        //             for (int m = 0; m < sum.size(); m++)
        //             {
        //                 int sum1 = 0;
        //                 for (int n = m; n < sum.size(); n++)
        //                 {
        //                     sum1 += sum[n];
        //                     if (sum1 == target)
        //                     {
        //                         res++;
        //                     }
        //                 }
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
