using System;
using System.Collections.Generic;

namespace AlgorithmPractice
{
    public class QuickSort
    {
        public void Sort(List<int> arr)
        {
            QSort(arr, 0, arr.Count-1);
        }

        private void QSort(List<int> arr, int l, int r)
        {
            if (l >= r )
                return;

            //int q = Partition(arr, l, r);
            //int q = Partition2(arr, l, r);
            int q = Partition3(arr, l, r);
            QSort(arr, l, q);
            QSort(arr, q+1, r);
        }


        //If array is already sorted, this quick sort will become O(n^2) since every partition only has one partition instead of two
        //To fix it, we can easily change the pivot value to a random element.
        private int Partition(List<int> arr, int l, int r)
        {
            //search in [l, r]
            //left less than v: [l+1, j], right greater than v: [j+1, i), i is the one we will check.
            var v = arr[l];
            var j = l;            
            for(int i=l+1; i <= r; i++ )
            {
                if (arr[i] < v)
                {
                    SortHelper.Swap(arr, j+1, i);
                    j++;
                }
            }
            SortHelper.Swap(arr, l, j);
            return j;
        }


        //This version use a random element as a pivot which will greatly improve performance for almost sorted list.
        private int Partition2(List<int> arr, int l, int r)
        {
            //search in [l, r]
            //left less than v: [l+1, j], right greater than v: [j+1, i), i is the one we will check.
            //ideally the pivot should be exactly the middle of this partition, however it is difficult to 
            //get that value, we choose a random index which has very low possibility to be first pivot.
            var randomIndex = (new Random().Next() % (r-l+1)) + l;
            SortHelper.Swap(arr, l, randomIndex);
            
            var v = arr[l];            
            var j = l;            
            for(int i=l+1; i <= r; i++ )
            {
                if (arr[i] < v)
                {
                    SortHelper.Swap(arr, j+1, i);
                    j++;
                }
            }
            SortHelper.Swap(arr, l, j);
            return j;
        }

        //Partition2 has bad performance if the array contains lots of duplicated elements, because the partition
        //will still make the two partition inbalance, one of the partition containing the duplicated element is large.
        //This method is a new approach to make partition from two different direction, the duplicated elements will be
        //put in two partitions so that the partition is more balanced.
        private int Partition3(List<int> arr, int l, int r)
        {
            var randomIndex = (new Random().Next() % (r-l+1)) + l;
            SortHelper.Swap(arr, l, randomIndex);

            var v = arr[l];
            int i = l+1;
            int j= r;
            //left: [l+1, i) < right (j,r]; i and j are the ones we will check.
            while(true)
            {
                while(i <= r && arr[i] < v) i++;
                while(j >= l+1 && arr[j] > v) j--;                
                if (i > j)
                    break;

                SortHelper.Swap(arr, i, j);
                i++;
                j--;
            }

            SortHelper.Swap(arr, l, j);
            return j;
        }

        //Quick sort 3 ways
        // private int Partition4(List<int> arr, int l, int r)
        // {
            
        // }
    }
}