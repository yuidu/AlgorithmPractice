

using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;

namespace AlgorithmPractice
{

    public class Heapifier
    {
        //所有的叶子结点本身就是一个最大堆，所以从第一个非叶子结点开始，依次让它变成堆，直到整棵二叉树成为二叉堆。
        public void Heapify(ref int[] arr)
        {
            for (int i = arr.Length / 2; i >= 1; i--)
            {
                ShiftDown(ref arr, i);
            }
        }

        private void ShiftDown(ref int[] arr, int i)
        {
            while (2 * i < arr.Length)
            {
                int toBeSwap = 2 * i; //左孩子
                if (arr[2 * i] < arr[2 * i + 1])
                    toBeSwap = 2 * i + 1;
                if (arr[i] > arr[toBeSwap])
                    break;
                Swap(ref arr, i, toBeSwap);
                i = toBeSwap;
            }
        }

        private void Swap(ref int[] arr, int p, int q)
        {
            var temp = arr[p];
            arr[p] = arr[q];
            arr[q] = temp;
        }
    }

}