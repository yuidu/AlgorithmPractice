using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode
{
    class LintCode1716_FlipStringToIncreasingcs
    {
        // public int minFlipsMonoIncr(String S)
        // {
        //     int[] leftOnes = new int[S.length()];
        //     int ones = 0;
        //     for (int i = 0; i < S.length(); i++)
        //     {
        //         if (S.charAt(i) == '1')
        //         {
        //             ones++;
        //         }
        //         leftOnes[i] = ones;
        //     }
        //
        //     int flips = S.length() - ones;
        //     for (int i = 0; i < S.length(); i++)
        //     {
        //         int rightOnes = ones - leftOnes[i];
        //         int rightZeroes = S.length() - i - 1 - rightOnes;
        //         flips = Math.min(flips, leftOnes[i] + rightZeroes);
        //     }
        //
        //     return flips;
        // }
    }
}
