using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
namespace AlgorithmPractice.LeetCode
{
    public class FreqToElement : IComparable
    {
        public int Frequency;
        public int Element;
        public FreqToElement()
        {

        }
        public FreqToElement(int ele, int freq)
        {
            this.Frequency = freq;
            this.Element = ele;
        }

        public int CompareTo(object obj)
        {
            if (!(obj is FreqToElement))
                return -1;
            if (Frequency < ((FreqToElement)obj).Frequency)
                return -1;
            else if(Frequency > ((FreqToElement)obj).Frequency)
                return 1;
            else
            {
                return 0;
            }
        }
    }
    public class TopKFrequency
    {
        public List<int> GetTopKFrequency(List<int> arr, int k)
        {
            if (k > arr.Count)
                return new List<int>();

            //首先计算频次 O(n)
            var eleToFreq = new Dictionary<int,int>();
            for(int i=0; i<arr.Count; i++)
            {
                eleToFreq.TryGetValue(arr[i], out int freq); // if fails, freq = 0;
                eleToFreq[arr[i]] = freq + 1;
            }
            
            //将频次加入优先队列（最小堆）中
            var minHeap = new MinHeap<FreqToElement>(k);
            foreach (var ef in eleToFreq)
            {
                if (minHeap.Size() < k)
                    minHeap.Insert(new FreqToElement(ef.Key,ef.Value));
                else
                {
                    var minEle = minHeap.Top();
                    if (ef.Value > minEle.Frequency)
                    {
                        minHeap.ExtractTop();
                        minHeap.Insert(new FreqToElement(ef.Key, ef.Value));
                    }
                }
            }

            
            var eleCount = minHeap.Size();
            var ret = new int[eleCount];
            for(int i=eleCount-1; i>=0; i--)
            {   
                ret[i] = minHeap.ExtractTop().Element;
            }
            return new List<int>(ret);
        }
    }
}