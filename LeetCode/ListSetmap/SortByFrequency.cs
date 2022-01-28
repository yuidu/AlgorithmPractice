using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.ListSetmap
{
    class SortByFrequency
    {
        public string FrequencySort(string s)
        {
            var chars = s.ToCharArray();
            var dict = new Dictionary<Char, int>();
            for (int i = 0; i < chars.Length; i++)
            {
                if (dict.ContainsKey(chars[i]))
                    dict[chars[i]]++;
                else
                    dict[chars[i]] = 1;
            }

            var sortedList = dict.OrderByDescending(x => x.Value);
            var sortedChars = sortedList.Select(x => x.Key).ToArray();
            return new string(sortedChars);
        }
    }
}
