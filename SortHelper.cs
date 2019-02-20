using System;
using System.Collections.Generic;

namespace AlgorithmPractice
{
    public class SortHelper{

        public static void Swap(List<int> arr, int first, int second )
        {
            if (first < 0 || first >= arr.Count)
                return;
            if (second < 0 || second >=arr.Count)
                return;
            int temp = arr[first];
            arr[first] = arr[second];
            arr[second] = temp;
        }
        public static bool IsSorted(List<int> arr)
        {
            for(int i=1; i<arr.Count; i++)
            {
                if (arr[i] < arr[i-1])
                    return false;
            }
            return true;
        }
    }
}
