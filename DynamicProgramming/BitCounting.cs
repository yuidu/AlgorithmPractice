using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmPractice.DynamicProgramming
{
    class BitCounting
    {
        public int[] CountingBits(int num)
        {
            int[] f = new int[num + 1];
            f[0] = 0;

            for (int i = 1; i < num; i++)
            {
                f[i] = f[i >> 1] + (i % 2);
            }

            return f;
        }
    }
}
