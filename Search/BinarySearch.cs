using System;
using System.Collections.Generic;

namespace AlgorithmPractice
{
    public class BinarySearch{
        public int Search(List<int> arr, int target)
        {
            //search in [l, r]
            int l = 0;
            int r = arr.Count-1;

            while(l <= r)
            {
                var mid = (l+r)/2;
                if (arr[mid] == target)
                {
                    return mid;
                }
                else if (target < arr[mid])
                {
                    r = mid - 1;
                }
                else
                {
                    l = mid + 1;
                }                
            }
            return -1;
        }

        //Use recursion approach
        public int Search2(List<int> arr, int target)
        {
            return -1;
        }
    }
}