using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace Leetcode.Recursive
{
    class _77_Combinations
    {
        // Input: n = 4, k = 2
        // Output:
        // [
        // [2,4],
        // [3,4],
        // [2,3],
        // [1,2],
        // [1,3],
        // [1,4],
        // ]
        //组合
        public void Test()
        {
            var res = Combine(4, 2);
            res.ToList().ForEach(x=>
            {
                x.ToList().ForEach(y=>Console.Write(y.ToString()));
                Console.WriteLine();
            });
        }

        public IList<IList<int>> Combine(int n, int k)
        {
            IList<IList<int>> res = new List<IList<int>>();
            GetCombinations(n, 1, k, new List<int>(), res);
            return res;
        }

        private void GetCombinations(int n, int start, int k, List<int> combines, IList<IList<int>> res)
        {
            if (combines.Count == k)
            {
                res.Add(new List<int>(combines));
                return;
            }
                
            for (int i = start; i <= n; i++)
            {
                combines.Add(i);
                GetCombinations(n, i + 1, k, combines, res);
                combines.RemoveAt(combines.Count - 1);
            }
        }

       
    }
}
