using System;
using System.Collections.Generic;

namespace AlgorithmPractice{ 
    
       public class RandomArrayGenerator{        
           public static List<int> Generate(int number, int leftBoundary, int rightBoundary)
           {
               var randoms = new List<int>();
              
               var rnd = new Random();
               for(int i=0; i< number; i++)
                    randoms.Add(rnd.Next(leftBoundary, rightBoundary));

                return randoms;
           }
       }
    
}