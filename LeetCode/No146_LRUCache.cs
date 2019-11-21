using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;

namespace AlgorithmPractice.LeetCode
{
    public class LRUCache
    {
        class DLinkedNode
        {
            public int key;
            public int value;
            public DLinkedNode prev;
            public DLinkedNode next;
        }

        private void addNode(DLinkedNode node)
        {
            //将新的node加入在头部的后面
            node.prev = head;
            node.next = head.next;

            head.next.prev = node;
            head.next = node;
        }

        private void removeNode(DLinkedNode node)
        {
            //从链表中移除一个node
            DLinkedNode prev = node.prev;
            DLinkedNode next = node.next;

            prev.next = next;
            next.prev = prev;
        }

        private void moveToHead(DLinkedNode node)
        {
            //将一个node移到队头
            removeNode(node);
            addNode(node);
        }

        private DLinkedNode popTail()
        {
            //移除当前队尾的元素
            DLinkedNode res = tail.prev;
            removeNode(res);
            return res;
        }

        private Hashtable cache = new Hashtable();
        private int size;
        private int capacity;
        private DLinkedNode head, tail;

        public LRUCache(int capacity)
        {
            this.size = 0;
            this.capacity = capacity;

            head = new DLinkedNode();
            // head.prev = null;

            tail = new DLinkedNode();
            // tail.next = null;

            head.next = tail;
            tail.prev = head;
        }

        public int Get(int key)
        {
            DLinkedNode node = (DLinkedNode)cache[key];
            if (node == null) return -1;

            // 将已存在的node移到队头
            moveToHead(node);

            return node.value;
        }

        public void Put(int key, int value)
        {
            DLinkedNode node = (DLinkedNode)cache[key];

            if (node == null)
            {
                DLinkedNode newNode = new DLinkedNode();
                newNode.key = key;
                newNode.value = value;

                cache.Add(key, newNode);
                addNode(newNode);

                ++size;

                if (size > capacity)
                {
                    //移除队尾元素
                    DLinkedNode tail = popTail();
                    cache.Remove(tail.key);
                    --size;
                }
            }
            else
            {
                // 更新node的值并移到队头
                node.value = value;
                moveToHead(node);
            }
        }
    }
}

