using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.MS
{
    class LC1888_flipValues
    {
        // public int minFlips(String s)
        // {
        //     String target = "01";
        //     int count = 0;
        //     int len = s.length();
        //     for (int i = 0; i < len; i++)
        //     {
        //         if (s.charAt(i) != target.charAt(i % 2))
        //         {
        //             count++;
        //         }
        //     }
        //     int ans = Math.min(count, len - count);
        //     s += s;
        //     for (int i = 0; i < len; i++)
        //     {
        //         if (s.charAt(i) != target.charAt(i % 2))
        //         {
        //             count--;
        //         }
        //         if (s.charAt(i + len) != target.charAt((i + len) % 2))
        //         {
        //             count++;
        //         }
        //         ans = Math.min(ans, Math.min(count, len - count));
        //     }
        //     return ans;
        // }




        // int minFlips(string s)
        // {
        //     int odd1 = 0, odd0 = 0;
        //     int even1 = 0, even0 = 0;
        //     for (int i = s.size() - 1; i >= 0; i--)
        //     {
        //         if (i % 2 == 0)
        //         {
        //             if (s[i] == '0') even0++;
        //             else even1++;
        //         }
        //         else
        //         {
        //             if (s[i] == '0') odd0++;
        //             else odd1++;
        //         }
        //     }
        //
        //     int ops = s.size();
        //     for (int i = 0; i < s.size(); ++i)
        //     {
        //         if (s.size() % 2 == 0)
        //         {
        //             std::swap(odd1, even1);
        //             std::swap(odd0, even0);
        //         }
        //         else
        //         {
        //             if (s[i] == '0')
        //                 even0--;
        //             else
        //                 even1--;
        //             std::swap(odd1, even1);
        //             std::swap(odd0, even0);
        //             if (s[i] == '0')
        //                 even0++;
        //             else
        //                 even1++;
        //         }
        //         ops = min(ops, min(odd0 + even1, odd1 + even0));
        //     }
        //
        //     return ops;
        // }
        //
        // 作者：yanghan234
        //     链接：https://leetcode-cn.com/problems/minimum-number-of-flips-to-make-the-binary-string-alternating/solution/cqiao-miao-jie-fa-tong-ji-qi-ou-wei-01ge-jq93/
        // 来源：力扣（LeetCode）
        // 著作权归作者所有。商业转载请联系作者获得授权，非商业转载请注明出处。
    }
}
