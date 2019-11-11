
using System;

public class LongestPalindromic
{
    
    ///Bruit force  O(n3)
        public string LongestPalindrome(string s) {
        int i=0;
        int j=0;
        var chars = s.ToCharArray();
        int maxLength = 0;
        string longestStr = string.Empty;
        while(i < s.Length && j < s.Length)
        {
            //Check if in range [i,j] is a palindromic substring.
            int m = i;
            if (isPalindromic(chars, m, j))
            {
                //maxLength = Math.Max(maxLength, j-i+1);
                if (j-i+1 > maxLength)
                {
                    longestStr = new string(chars, m, j-m+1);
                    maxLength = Math.Max(maxLength, j-i+1);
                }
                    
            }
                
            
            j++;
            if (j == s.Length)
            {
                i++;
                j = i;
            }
                
        }
        return longestStr;
    }
    
    private bool isPalindromic(char[] chars, int left, int right)
    {
        if (left > right)
            return false;
        
        while(left <= right)
        {
            if (chars[left++] != chars[right--])
                return false;            
        }
        
        return true;
    }
}