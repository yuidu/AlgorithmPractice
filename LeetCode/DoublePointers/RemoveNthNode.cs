using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.DoublePointers
{
    public class ListNode
    {
        public int val;
        public ListNode next;
        public ListNode(int val = 0, ListNode next = null)
        {
            this.val = val;
            this.next = next;
        }
    }

    public class RemoveNthNode
    {
        public ListNode RemoveNthFromEnd(ListNode head, int n)
        {
            int i = 0;
            ListNode dummyHead = new ListNode();
            dummyHead.next = head;

            ListNode firstNode = head;
            while (++i < n)
            {
                firstNode = firstNode.next;
            }

            ListNode secNode = dummyHead.next;
            while (firstNode.next != null)
            {
                firstNode = firstNode.next;
                secNode = secNode.next;
            }

            if (secNode.next != null)
                secNode.next = secNode.next.next;

            return dummyHead.next;
        }

        public void TestRemoveNth()
        {
            ListNode head = new ListNode(1, new ListNode(2, new ListNode(3, new ListNode(4, new ListNode(5, null)))));
            var newHead = new RemoveNthNode().RemoveNthFromEnd(head, 2);

            var cur = newHead;
            while (cur != null)
            {
                Console.Write(cur.val + ",");
                cur = cur.next;
            }
        }
    }  
}
