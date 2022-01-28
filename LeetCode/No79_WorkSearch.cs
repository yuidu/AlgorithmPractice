using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmPractice.LeetCode
{
    // Input: board = [["A","B","C","E"],["S","F","C","S"],["A","D","E","E"]], word = "ABCCED"
    // Output: true
    //
    class No79_WorkSearch
    {
        public bool Exist(char[][] board, string word)
        {
            var chars = word.ToCharArray();
            var m = board.Length;
            if (m < 1)
                return false;
            var n = board[0].Length;
            isVisited = new bool[m][];
            for (int i = 0; i < m; i++)
            {
                isVisited[i] = new bool[n];
                for (int j = 0; j < n; j++)
                {
                    isVisited[i][j] = false;
                }
            }

            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (Search(board, i, j, m, n, 0, chars))
                        return true;
                }
            }
            return false;
        }

        private int[] dx = new int[4] { 0, 0, -1, 1 };
        private int[] dy = new int[4] { 1, -1, 0, 0 };
        private bool[][] isVisited;


        private bool Search(char[][] board, int x, int y, int m, int n, int index, char[] chars)
        {
            if (index == chars.Length - 1)
                return board[x][y] == chars[index];

            if (board[x][y] == chars[index])
            {
                isVisited[x][y] = true;
                for (int i = 0; i < 4; i++)
                {
                    int newX = x + dx[i];
                    int newY = y + dy[i];
                    if (newX >= 0 && newX < m && newY >= 0 && newY < n && index < chars.Length && !isVisited[newX][newY])
                    {
                        if (Search(board, newX, newY, m, n, index + 1, chars))
                            return true;
                    }
                }
                isVisited[x][y] = false;
            }

            return false;
        }
    }
}
