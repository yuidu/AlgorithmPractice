using System;
using System.Collections.Generic;
using System.Text;

namespace AlgorithmPractice.matrix
{
    class SetZero
    {
        //LC73
        // Given an m x n integer matrix matrix, if an element is 0,
        // set its entire row and column to 0's, and return the matrix.
        //
        //     You must do it in place.
        //
        //
        //
        //     Example 1:
        //
        //
        // Input: matrix = [[1,1,1],[1,0,1],[1,1,1]]
        // Output: [[1,0,1],[0,0,0],[1,0,1]]
        // Example 2:
        //
        //
        // Input: matrix = [[0,1,2,0],[3,4,5,2],[1,3,1,5]]
        // Output: [[0,0,0,0],[0,4,5,0],[0,3,1,0]]
        //
        //Solution 1:  常量级空间复杂度
        void setZeroes(List<List<int>> matrix)
        {
            int m = matrix.Count;
            if (m == 0) return;
            int n = matrix[0].Count;
            bool row0 = false, col0 = false;
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (matrix[i][j] == 0)
                    {
                        if (i == 0) row0 = true;
                        if (j == 0) col0 = true;
                        matrix[0][j] = matrix[i][0] = 0;
                    }
                }
            }
            for (int i = 1; i < m; i++)
            {
                for (int j = 1; j < n; j++)
                {
                    if (matrix[0][j] == 0 || matrix[i][0] == 0)
                        matrix[i][j] = 0;
                }
            }
            if (col0)
                for (int i = 0; i < m; i++) matrix[i][0] = 0;
            if (row0)
                for (int j = 0; j < n; j++) matrix[0][j] = 0;
        }

        //Solution 2:  O(m+n)级空间复杂度
        // void setZeroes(vector<vector<int>> &matrix)
        // {
        //     if (matrix.size() < 1) return;
        //     vector<int> col(matrix[0].size(),0);
        //     vector<int> row(matrix.size());
        //     for (int i = 0; i < matrix.size(); i++)
        //     {
        //         for (int j = 0; j < matrix[0].size(); j++)
        //         {
        //             if (matrix[i][j] == 0)
        //             {
        //                 row[i] = 1;
        //                 col[j] = 1;
        //             }
        //         }
        //     }
        //     for (int i = 0; i < matrix.size(); i++)
        //     for (int j = 0; j < matrix[0].size(); j++)
        //         if (row[i] == 1 || col[j] == 1)
        //             matrix[i][j] = 0;
        // }

    }
}
