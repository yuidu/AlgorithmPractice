using System.Collections.Generic;
using System;

public class LengthOfLongestSubstringLC {

    //Solution 1
    public int LengthOfLongestSubstring(string s) {
        var chars = s.ToCharArray();
          int i=0, j=0;
          var maxLength = 0;
          while(i < chars.Length)
          {  
              j = i+1;
              while (j < chars.Length)
              {
                  int k = i;
                  bool reached = false;
                  while (k < j)
                  {
                      if (chars[k] == chars[j])
                      {
                          reached =  true;                        
                          break;
                      }                      

                      k++;
                  }
                  
                  if (reached)
                      break;
                  
                  j++;
              }             
            
              if (j-i > maxLength)
              {
                  maxLength = j - i;                          
              }
              i++;                       
          }

          return maxLength;
    }


    public int LengthOfLongestSubstring_2(string s){
        var chars = s.ToCharArray();
        int i = 0;
        int j = 0;
        int maxLength = 0;
        
        var htChars = new Dictionary<char,int>();
        while (i < s.Length - 1 && j < s.Length)
        {
            if (!htChars.ContainsKey(chars[j]))
            {
                htChars[chars[j++]] = 1;
            }
            else
            {                                
                htChars.Remove(chars[i++]);
            }   
            maxLength = Math.Max(maxLength,j-i);         
        }

        return maxLength;
    }
}