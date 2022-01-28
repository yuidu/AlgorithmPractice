using System;
using System.Collections.Generic;
using System.Text;

namespace AlgorithmPractice.matrix
{
    class SearchMatrix
    {
        // Write an efficient algorithm that searches for a value in an m x n matrix.This matrix has the following properties:
        //
        // Integers in each row are sorted from left to right.
        //     The first integer of each row is greater than the last integer of the previous row.
        // Consider the following matrix:
        //
        // [
        // [1,   3,  5,  7],
        // [10, 11, 16, 20],
        // [23, 30, 34, 50]
        // ]
        // Given target = 3, return true.
        bool searchMatrix(List<List<int>> matrix, int target)
        {
            int m = matrix.Count;
            if (m < 1) return false;
            int n = matrix[0].Count;
            int low = 0, high = m * n - 1;
            while (low <= high)
            {
                int mid = (low + high) / 2;
                int row = mid / n;
                int col = mid % n;
                if (target == matrix[row][col]) return true;
                if (target > matrix[row][col]) low = mid + 1;
                else high = mid - 1;
            }
            return false;
        }


       

    }
}
