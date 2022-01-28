using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.Recursive
{
    class _51_NQueens
    {
        // 寻找n皇后的所有可能放法 
        // 逐行找，在一行中看皇后可以放在哪一列，判断是否列被占用，左下到右上对角是否占用(用00,01表示单元格，对角所有的单元格和为1,2,3,...)
        //左上到右下对角是否被占用 (所有斜对角和为 -n...+n, 校正到index上就是index - i + n - 1 
        private List<List<string>> res = new List<List<string>>();
        private List<bool> col;
        private List<bool> dia1;
        private List<bool> dia2;

        public List<List<string>> SolveQueen(int n)
        {
            col = Enumerable.Repeat(false, n).ToList();
            dia1 = Enumerable.Repeat(false, 2*n-1).ToList();
            dia2 = Enumerable.Repeat(false, 2 * n - 1).ToList();

            List<int> row = new List<int>();
            putQueen(n, 0, row);
            return res;
        }

        List<string> generateBoard(int n, List<int> row)
        {
            var board = new List<string>();
            for (int i = 0; i < n; i++)
            {
                var curRow = "";
                for (int j = 0; j < n; j++)
                {
                    if (j == row[i])
                        curRow += 'Q';
                    else
                        curRow += ".";
                }

                board[i] = curRow;
            }

            return board;
        }
        void putQueen(int n, int index, List<int> row)
        {
            if (index == n)
            {
                res.Add(generateBoard(n,row));
            }

            for (int i = 0; i < n; i++)
            {
                //尝试将第index行的皇后摆放在第i列
                if (!col[i] && !dia1[index + i] && dia2[index - i + n - 1])
                {
                    row.Add(i);
                    col[i] = true;
                    dia1[index + i] = true;
                    dia2[index - i + n - 1] = true;
                    putQueen(n, index+1, row);
                    col[i] = false;
                    dia1[index + i] = false;
                    dia2[index - i + n - 1] = false;
                    row.RemoveAt(row.Count-1);
                }
            }
        }



    }
}
