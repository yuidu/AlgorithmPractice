using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;

namespace AlgorithmPractice.LeetCode
{
    public class MinHeap<T> where T : class, IComparable, new()
    {
        private T[]  _items;
        private int _count;
        private int _capacity;

        public MinHeap(int capacity)
        {
            //_items = new List<T>(capacity+1);
            _items = new T[capacity+1];
            _count = 0;
            _items[0] = null;
            _capacity = capacity;
        }
        public void Insert(T ele)
        {
            if (_count + 1 > _capacity)
                return;
            _items[++_count] = ele;
            ShiftUp(_count);
        }

        public int Size()
        {
            return _count;
        }
        private void ShiftUp(int k)
        {
            while(k > 1 && _items[k].CompareTo(_items[k/2]) < 0)
            {
                HeapHelper.Swap<T>(_items, k, k/2);
                k = k/2;
            }
        }

        public T ExtractTop()
        {
            if (_count < 1)
                return null;

            var top = _items[1];
            HeapHelper.Swap<T>(_items, 1, _count);
            _count--;
            ShiftDown(1);
            return top;
        }

        public T Top(){
            return _items[1];
        }
           
        private void ShiftDown(int k)
        {
            while (2*k < _count)
            {
                var toBeSwapIndex = 2*k;
                if (2*k+1 <=_count && _items[2*k + 1 ].CompareTo(_items[2*k]) < 0)
                    toBeSwapIndex = 2*k + 1;

                if (_items[k].CompareTo(_items[toBeSwapIndex]) < 0)
                    break;

                HeapHelper.Swap<T>(_items,k, toBeSwapIndex);
                k = toBeSwapIndex;
            }
        }
    }
}