using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode
{
    class LintCode1734_SumofSubarrayMinimums
    {
        // 假设从数组的头部遍历，如果后面的数大于前面的数，那么这两个数构成的子数组取得肯定是前面的小的数；
        // 如果后面的数小于前面的数，那么子数组就得取后面的数。
        // 那么当前元素的贡献就是：
        // A[i] * A[i] 与其前一个较少的元素之间的距离 * A[i] A[i]与其下一个较小元素之间的距离
        //     将所有元素的贡献相加即可。
        // int sumSubarrayMins(vector<int> &A)
        // {
        //     // Write your code here.
        //     int res = 0, n = A.size(), mod = 1e9 + 7, j, k;
        //     stack<int> s;
        //     for (int i = 0; i <= n; ++i)
        //     {
        //         while (!s.empty() && A[s.top()] > (i == n ? 0 : A[i]))
        //         {
        //             j = s.top(), s.pop();
        //             k = s.empty() ? -1 : s.top();
        //             res = (res + A[j] * (i - j) * (j - k)) % mod;
        //         }
        //         s.push(i);
        //     }
        //     return res;
        // }
    }
}
