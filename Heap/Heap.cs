//1） 二叉堆
//最大堆，性质： 1. 任何子结点都不大于父结点，2. 是一棵完全二叉树。（除最后一层外，其它层必须是最大值，最后一层所有结点都集中在左侧）
//非常经典的一个实现是用数组存储二叉堆： 因为堆是完全二叉树，所以可以用数组进行存储

//2)用数组存储堆
//如果给某个结点按照层序至上至下从左至右从1开始进行编号ß，那么就有左结点是2k,右结点是2K+1
//0  1  2  3 4 5 ....
//- 52 41  20 ....
//数组存储索引0的位置不使用，这样方便用于检索

//3) Heapify
//Heapify: 就是把一个普通数组变成最大堆
//第一个非叶子结点的位置是结点数/2
//Heapify的操作是，从第一个非叶子结点开始做shiftdown操作直到根结点，这样整个数组就成了堆的结构了
//heapify对一个已有数组变成堆的时间复杂度是O(n),而将每个元素进入堆逐渐形成堆的时间复杂度是O(nlogn)

//4) 原地堆排序
//思路是： 先进行heapify把数组变成一个堆，然后把第一个数后最后一个数交换，最大数就放好了
//接着把除最后一个数外的其它数再次heapify变成堆，然后再取出第一个数与倒数第二个数交换，这样第二大的数也放好了，依次进行直到全部排好序。

//5) 索引堆
//如果元素是复杂结构，而引入索引堆
//     0 1   2  3 4 5 6 7 8 9 10
//index: 10  9  7 8 5 6 3 ... 
//data : 15 17
//将index建成堆，比较的时候是data,而真正交换的是index


using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;

namespace AlgorithmPractice {

public class HeapItem
{
    public int value;
}

public class MaxHeapV3
{
    private List<HeapItem> _items;
    private int _count;
    private int _capacity;

    public MaxHeapV3(int capacity)
    {
        _capacity = capacity;
        _items = new List<HeapItem>(_capacity + 1);
        _count = 0;
    }
    
    //当有一个新元素加入，开始加到末尾，和它的父亲比如果比父亲更大，和父亲交换直到结束
    public void insert(HeapItem item)
    {
        if (_count + 1 > _capacity)
            return;

        _items[_count] = item;
        ShiftUp(_count);
    }

    private void ShiftUp(int i)
    {
        while (i > 1 && _items[i].value > _items[i/2].value){
            Swap(i, i/2);
            i = i/2;
        }
    }

    private void Swap(int p, int q)
    {
        var v = _items[p];
        _items[p] = _items[q];
        _items[q] = v; 
    }


    //当需要取出最大值时，将根结点取出，然后将最后一个结点放到根结点的位置执行shiftDown，shift down就是将当前结点和左右孩子对比，哪个孩子大和哪个孩子交换，一直比较下去
    public HeapItem ExtractHeap()
    {
        if (_count == 0)
            return null;

        var lagestEle = _items[1];
        Swap(1, _count);
        ShiftDown(1);

        return lagestEle;
    }

    private void ShiftDown(int i)
    {
        while( 2*i < _count)
        {            
            int toBeSwap = 2 * i;
            if ((2*i) + 1 <_count && _items[toBeSwap].value < _items[toBeSwap + 1].value)
            {
                toBeSwap = 2 * i + 1;
            }

            if (_items[i].value > _items[toBeSwap].value)
               break;
            
            Swap(i, toBeSwap);
            i = toBeSwap;
        }
    }

    public int Size()
    {
        return _count;
    }


   
}

}
