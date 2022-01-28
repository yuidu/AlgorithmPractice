using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.Recursive
{
    public class _17_LetterCombination
    {
        public _17_LetterCombination()
        {
        }

        public void Test()
        {
            var res = LetterCombinations("234");
            res.ToList().ForEach(Console.WriteLine);
        }

        private IDictionary<int, char[]> _digitToLetters = new Dictionary<int, char[]>()
        {
            {1, null},
            {2, new char[3] { 'a', 'b', 'c' }},
            {3, new char[3] { 'd', 'e', 'f' }},
            {4, new char[3] { 'g', 'h', 'i' }},
            {5, new char[3] { 'j', 'k', 'l' }},
            {6, new char[3] { 'm', 'n', 'o' }},
            {7, new char[4] { 'p', 'q', 'r','s' }},
            {8, new char[3] { 't', 'u', 'v' }},
            {9, new char[4] { 'w', 'x', 'y','z' }}
        };
        public IList<string> LetterCombinations(string digits)
        {
            var res = new List<string>();
            string combinedLetters = "";
            Combinations(digits, 0, combinedLetters, res);
            return res;
        }


        private void Combinations(String digits, int index, string combinedLetters, List<string> res)
        {
            if (index == digits.Length)
            {
                if (!string.IsNullOrEmpty(combinedLetters))
                    res.Add(combinedLetters);
                return;
            }

            var key = int.Parse(digits[index].ToString());
            var letters = _digitToLetters[key];
            for (var i = 0; i < letters.Length; i++)
            {
                var letter = letters[i];
                // combinedLetters += letter;
                Combinations(digits, index + 1, combinedLetters + letter, res);
                // combinedLetters = combinedLetters.Remove(combinedLetters.Length - 1);
            }
        }




    }



       
    
}
