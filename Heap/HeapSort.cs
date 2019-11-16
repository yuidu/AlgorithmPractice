using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;

namespace AlgorithmPractice {
    public class HeapSortV3{

        public HeapSortV3()
        {

        }

        public void Sort(ref int[] arr)
        {
            var heapifier = new Heapifier();
            heapifier.Heapify(ref arr);
            
            for(int i=arr.Length-1; i >=0; i--)
            {
                Swap(ref arr, 0, i);
                ShiftDown(ref arr, 0, i-1);
            }
        }

        private void Swap(ref int[] arr, int p, int q)
        {
            var temp = arr[p];
            arr[p] = arr[q];
            arr[q] = temp;
        }

        private void ShiftDown(ref int[] arr, int start, int stop)
        {
            var i = start;
            while(2*i < stop)
            {
                var tobeSwap = 2 * i;
                if (arr[2*i] < arr[2*i+1])
                    tobeSwap = 2*i+1;
                if (arr[i] > arr[tobeSwap])
                    break;

                Swap(ref arr, i, tobeSwap);
                i = tobeSwap;
            }
        }        
    }
}