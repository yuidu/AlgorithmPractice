using System;
using System.Collections.Generic;

namespace AlgorithmPractice
{
    public class SelectionSorting{
        public void Sort(List<int> arr)
        {
            for(int i=0; i<arr.Count; i++)
            {                
                int minIndex = i;
                int minValue = arr[i];                
                for(int j=i+1; j<arr.Count; j++)
                {
                    if (arr[j] < minValue)
                    {
                        minIndex = j;
                        minValue = arr[j];
                    }                        
                }

                SortHelper.Swap(arr, i, minIndex);
            }
        }

        public void Sort2(List<int> arr)
        {
            for(int i=0; i<arr.Count; i++)
            {                
                int minIndex = i;                
                for(int j=i+1; j<arr.Count; j++)                
                    if (arr[j] < arr[minIndex])
                        minIndex = j;           
                SortHelper.Swap(arr, i, minIndex);
            }
        }       
       
    }
}