using System;
using System.Collections.Generic;

namespace AlgorithmPractice
{
    public class InsertionSort{
        
        //Swaping element in array take longer time, 
        //therefore performance is not good enough even comparing to selection sort.
        public void Sort(List<int> arr)
        {
            for(int i=1; i<arr.Count; i++)
            {
                for(int j=i; j>0; j--)
                {
                    if (arr[j] < arr[j-1])
                       SortHelper.Swap(arr, j, j-1);
                    else
                       break;
                }
            }
        }
        
        //This version of insertion sort has better performance, which is better than selection sort since
        //it only compares partial elements and it doesn't have swap operation that takes longer time.
        //if the array is almost sorted, then this insertion sort has good performance since it will break ealier
        //for almost sorted array, insertion sort is even faster than O(nlogn) sorting algorithm.
        //if the array is already sorted, insertion sort is O(n), because inner loop return immediately.
        public void Sort2(List<int> arr)
        {
            for(int i=1; i<arr.Count; i++)
            {
                int e = arr[i];                
                for(int j=i; j>0; j--)
                {
                    if (arr[j-1]> e)
                        arr[j] = arr[j-1];
                    else
                        arr[j] = e;
                }                
            }
        }
    }
}