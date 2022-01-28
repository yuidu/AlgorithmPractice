using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.ListSetmap
{
    class _290_IsWorkPattern
    {
        public void Test()
        {
            //Input: pattern = "abba", s = "dog cat cat dog"
            //Output: true
        }


        public bool WordPattern(string pattern, string s)
        {
            var strs = s.Split(' ');
            var pStrs = pattern.ToCharArray();
            var pToS = new Dictionary<char, string>();
            var sToP = new Dictionary<string, char>();

            if (pStrs.Length != strs.Length)
                return false;

            for (int i = 0; i < strs.Length; i++)
            {
                if (!pToS.ContainsKey(pStrs[i]))
                    pToS.Add(pStrs[i], strs[i]);
                else
                {
                    if (strs[i] != pToS[pStrs[i]])
                        return false;
                }

                if (!sToP.ContainsKey(strs[i]))
                    sToP.Add(strs[i], pStrs[i]);
                else
                {
                    if (pStrs[i] != sToP[strs[i]])
                        return false;
                }
            }

            return true;
        }
    }
}
