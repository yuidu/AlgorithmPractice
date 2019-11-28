using System;
using System.Collections;
using System.Collections.Generic;

namespace AlgorithmPractice.Recursion {
    public class Recursion
    {
        public int Factorial(int n)
        {
            if (n==1)           //1. 思考当处地边界条件时，函数的意义，函数的返回是多少
                return 1;       //函数在计算n=1人时候的阶乘，当n=1的的阶乘为 1

            return n * Factorial(n-1);   //2. 思考当n-1的函数结果返回时，当前函数层的任务是什么，该怎么返回数值
                                         // 当n-1的阶乘已经被计算出来后，本轮的任务是计算n的阶乘，那么就是n * (n-1)!                                        
        } 

        public class TNode
        {
            public int Value;
            public TNode Next; 
            public TNode(int value)
            {
                this.Value = value;
                this.Next = null;
            }
        }

        //使用数组创建链表
        public TNode CreateLinkList(int[] arr)
        {
            return CreateLinkList(ref arr, arr.Length-1);
        }

        //创建一个以index为末尾结点的链表
        private TNode CreateLinkList(ref int[] arr, int index)
        {   
            if (index == 0)      
                return new TNode(arr[00]);

            //index-1的链表已经创建好了，如果处理index所在结点
            var newHead = CreateLinkList(ref arr, index - 1);
            var newNode = new TNode(arr[index]);
            newNode.Next = newHead;            

            return newNode;
        }


        //反转链表，传入旧的链表头，返回新的链表头
        //      a -> b -> c - >d -> null
        //   null <- b <- c <- d
        private TNode ReverseLinkList(TNode node)
        {
            if (node.Next == null)
                return node;
            
            var head = ReverseLinkList(node.Next);
            node.Next.Next = node;
            node.Next = null;

            return head;
        }


        
    }
}