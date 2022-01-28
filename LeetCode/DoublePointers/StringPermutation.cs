using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.DoublePointers
{
    class StringPermutation
    {
        public void test()
        {
            bool ret = CheckInclusion("adc", "dcda");
        }
        public bool CheckInclusion(string s1, string s2)
        {
            var chars1 = s1.ToCharArray();
            var chars2 = s2.ToCharArray();

            int[] letters = new int[26];
            reset(chars1, letters);
            for (int i = 0; i < chars2.Length; i++)
            {
                if (visit(chars1, chars2[i], letters))
                {
                    if (isPermutation(chars1, letters))
                        return true;
                }
                else
                {
                    reset(chars1, letters);
                }
            }

            return false;
        }

        private void reset(Char[] chars1, int[] letters)
        {
            for (int i = 0; i < 26; i++)
            {
                letters[i] = 0;
            }
            for (int i = 0; i < chars1.Length; i++)
            {
                if (letters[chars1[i] - 'a'] == 0)
                    letters[chars1[i] - 'a'] = 2;
                else
                    letters[chars1[i] - 'a']++;
            }
        }

        private bool visit(Char[] chars, char target, int[] letters)
        {
            if (letters[target - 'a'] == 0)
                return false;

            letters[target - 'a']--;
            return true;
        }

        private bool isPermutation(Char[] chars, int[] letters)
        {
            for (int i = 0; i < chars.Length; i++)
            {
                if (letters[chars[i] - 'a'] != 1)
                    return false;
            }
            return true;
        }
    }
}
