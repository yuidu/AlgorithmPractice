using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmPractice
{
    class Class1
    {
        public int solution(string S)
        {
            // write your code in C# 6.0 with .NET 4.5 (Mono)
            var dirDict = new Dictionary<char, int>();
            var chars = S.ToCharArray();

            for (int i = 0; i < chars.Length; i++)
            {
                if (!dirDict.ContainsKey(chars[i]))
                {
                    dirDict.Add(chars[i], 1);
                }
                else
                {
                    dirDict[chars[i]]++;
                }
            }

            var im = dirDict.GetEnumerator();
            var lst = new List<int>();
            if (im.MoveNext())
            {
                lst.Add(im.Current.Value);
            }

            lst.Sort();
            if (lst.Count == 1)
                return 0;

            int sum = 0;
            for (int i = 0; i < lst.Count - 1; i++)
            {
                sum += lst[i];
            }
            return sum;
        }

    }
}
