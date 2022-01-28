using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode
{
    class _828_uniqueSubStrings
    {
        // 我们定义了一个函数 countUniqueChars(s) 来统计字符串 s 中的唯一字符，并返回唯一字符的个数。
        //
        // 例如：s = "LEETCODE" ，则其中 "L", "T","C","O","D" 都是唯一字符，因为它们只出现一次，所以 countUniqueChars(s) = 5 。
        //
        // 本题将会给你一个字符串 s ，我们需要返回 countUniqueChars(t) 的总和，其中 t 是 s 的子字符串。注意，某些子字符串可能是重复的，但你统计时也必须算上这些重复的子字符串（也就是说，你必须统计 s 的所有子字符串中的唯一字符）。
        //
        // 由于答案可能非常大，请将结果 mod 10 ^ 9 + 7 后再返回。

        // 输入: s = "ABC"
        // 输出: 10
        // 解释: 所有可能的子串为："A","B","C","AB","BC" 和 "ABC"。
        // 其中，每一个子串都由独特字符构成。
        // 所以其长度总和为：1 + 1 + 1 + 2 + 2 + 3 = 10
        //
        // Map<Character, List<Integer>> index;
        // int[] peek;
        // int N;
        //
        // public int uniqueLetterString(String S)
        // {
        //     index = new HashMap();
        //     peek = new int[26];
        //     N = S.length();
        //
        //     for (int i = 0; i < S.length(); ++i)
        //     {
        //         char c = S.charAt(i);
        //         index.computeIfAbsent(c, x-> new ArrayList<Integer>()).add(i);
        //     }
        //
        //     long cur = 0, ans = 0;
        //     for (char c: index.keySet())
        //     {
        //         index.get(c).add(N);
        //         index.get(c).add(N);
        //         cur += get(c);
        //     }
        //
        //     for (char c: S.toCharArray())
        //     {
        //         ans += cur;
        //         long oldv = get(c);
        //         peek[c - 'A']++;
        //         cur += get(c) - oldv;
        //     }
        //     return (int)ans % 1_000_000_007;

    }
}
