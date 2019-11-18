using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
namespace AlgorithmPractice.LeetCode
{
    public class CombineLetters
    {
        private static Dictionary<int,string> digitToChars = 
        new System.Collections.Generic.Dictionary<int, string>(){
            {1,"abc"},{2,"def"},{3,"ghi"},{4,"jkl"},{5,"mno"},{6,"pqr"},{7,"stu"},
            {8,"vw"},{9,"xyz"},{0,"-"}
        };

    
        private List<string> results;
        public CombineLetters()
        {

        }

        public List<string> GetAllCombinations(string digits)
        {
            return GetCombinations(digits,0, "");
        }
        public List<string> GetCombinations(string digits,int digitIndex, string combinedStr)
        {
            if (digitIndex >= digits.Length)
            {
                results.Add(combinedStr);
                return results;
            }
            var dig = digits.ToCharArray()[digitIndex];
            var alphebets = digitToChars[dig];
            var letters = alphebets.ToCharArray();
            for(int i=0; i<letters.Length;i++)
            {
                 GetCombinations(digits, digitIndex + 1, combinedStr + letters[i]);
            }
            return results;
        }
    }

    //这个算法时间复试度约为3^n, 被约等于O(2^n)，这个方法效率非常低下。
    //因为整个递归树，每层都是指数级增长。
    //这个方法称为回朔法，是一个暴力解法的主要实现手段，
    //回朔法可以通过剪枝来提高效率
    
}