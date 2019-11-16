using System;
using System.Collections.Generic;

namespace AlgorithmPractice
{
    public class MergeSort{
        public void Sort(List<int> arr)
        {
            Sort(arr, 0, arr.Count -1);
        }
        public void Sort(List<int> arr, int start, int stop)
        {
            //[start, stop]
            if (start >= stop)
                return;

            var mid = start + (stop - start)/2;            
            Sort(arr, start, mid);
            Sort(arr, mid+1, stop);
            if (arr[mid] > arr[mid+1])  //This check will greatly improve performance if the array is mostly sorted.
                MergeSubList(arr, start, mid, stop);
        }

        private void MergeSubList(List<int> arr, int start, int mid, int stop)
        {
            List<int> lst = new List<int>(arr.GetRange(start, stop-start+1));
            int i = start;
            int j = mid + 1;
            for(int k=start; k <=stop; k++)
            {
                if (i > mid)
                {
                    arr[k] = lst[j-start];
                    j++;
                }
                else if (j > stop)
                {
                    arr[k] = lst[i-start];
                    i++;
                }
                else if (lst[i-start] < lst[j-start])
                {
                    arr[k] = lst[i-start];
                    i++;
                }
                else
                {
                    arr[k] = lst[j-start];
                    j++;
                }                    
            }            
        }

        private void SortBU(List<int> arr, int start, int stop)
        {
            int n = arr.Count;
            for(int sz = 1; sz <= n; sz += 2*sz)
            {
                for(int i = 0; i + sz < n;  i += 2*sz)               
                    MergeSubList(arr, i, i + sz, i + 2 * sz);
            }
        }
    }
}