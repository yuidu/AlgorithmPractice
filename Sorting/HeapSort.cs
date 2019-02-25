using System;
using System.Collections.Generic;

namespace AlgorithmPractice
{
    public class HeapSort{

        public void Sort(List<int> arr)
        {
            var heap = new MaxHeap();

            arr.ForEach(x=>heap.Insert(x));
            for(int i = arr.Count-1; i >= 0; i--)
                arr[i] = heap.Extract();
        }

        public void Sort2(List<int> arr)
        {
            var heap = new MaxHeap(arr);
            for(int i = arr.Count-1; i >= 0; i--)
                arr[i] = heap.Extract();
        }

        //原地堆排序,no extra space, no copy, which save some time and space.
        public void Sort3(List<int> arr)
        {
            //heapify
            for(int i=(arr.Count-1)/2; i>=0; i--)            
                ShiftDown(arr, arr.Count, i);

            for(int i=arr.Count-1; i>=0; i--)
            {
                SortHelper.Swap(arr, 0, i);
                ShiftDown(arr, i, 0);
            }
        }       

        private void ShiftDown(List<int> arr, int len, int k)
        {
            while(2*k+1 < len)
            {
                int swapIndex = 2*k+1;
                if (2*k+2 < len && arr[2*k+2] > arr[2*k+1])
                    swapIndex = 2*k+2;

                if (arr[k] > arr[swapIndex])
                    break;

                SortHelper.Swap(arr, k, swapIndex);
                k = swapIndex;
            }
        }
    }
    public class MaxHeap{
        private List<int> items;
        private int itemCount;
        public MaxHeap(){
            items = new List<int>();
            items.Add(Int32.MinValue); // the first element is not used.
            itemCount = 0;
        }

        public MaxHeap(List<int> arr)
        {
            //Heapify:  has better performance than insert element every time, becuase insert is nlog(n) but
            //heapify operation can make it to O(n)
            items = new List<int>();
            items.Add(Int32.MinValue);  //first element is not used.            
            items.AddRange(arr);
            itemCount = arr.Count;
            for(int i= itemCount/2; i >= 1; i--)
            {
                ShiftDown(i);
            }            
        }
        public void Insert(int item)
        {
            items.Add(item);
            itemCount++;
            ShiftUp(itemCount);
        }

        private void ShiftUp(int itemIndex)
        {            
            //k/2 is k's parent.
            while(itemIndex != 1)
            {
                if (items[itemIndex] > items[itemIndex/2])
                    SortHelper.Swap(items, itemIndex, itemIndex/2);

                itemIndex = itemIndex/2;
            }            
        }
        public int Extract()
        {
            var root = items[1];
            SortHelper.Swap(items, 1, itemCount);
            items.RemoveAt(itemCount);
            itemCount--;

            ShiftDown(1);
            return root;
        }        

        private void ShiftDown(int itemIndex)
        {
            int i = itemIndex;
            while (2 * i < itemCount)
            {         
                //2*i is left child, 2*i + 1 is right child.       
                int swapIndex = 2 * i;
                if (itemCount > (2*i + 1) && items[2*i+1] > items[2*i])
                    swapIndex = 2 * i +1;

                if (items[i] > items[swapIndex])
                    break;
                
                SortHelper.Swap(items, i, swapIndex);
                i = swapIndex;                
            }
        }
    }
}