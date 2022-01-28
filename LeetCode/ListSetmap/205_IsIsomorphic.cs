using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.ListSetmap
{
    class IsIsomorphic
    {
        //My first solution
        public bool CheckIsIsomorphic(string s, string t)
        {
            var sChars = s.ToCharArray();
            var tChars = t.ToCharArray();

            if (sChars.Length != tChars.Length)
                return false;


            var sToT = new Dictionary<char, char>();
            var tToT = new Dictionary<char, char>();
            for (int i = 0; i < sChars.Length; i++)
            {
                if (sToT.ContainsKey(sChars[i]))
                {
                    if (sToT[sChars[i]] != tChars[i])
                        return false;
                }
                else
                    sToT.Add(sChars[i], tChars[i]);

                if (tToT.ContainsKey(tChars[i]))
                {
                    if (tToT[tChars[i]] != sChars[i])
                        return false;
                }
                else
                    tToT.Add(tChars[i], sChars[i]);
            }

            return true;
        }


    }
}
