using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.LinkList
{
    public class ListNode {
      public int val;
      public ListNode next;
      public ListNode(int val=0, ListNode next=null) {
         this.val = val;
          this.next = next;
      }
    }

    public class Solution
    {
        public ListNode ReverseBetween(ListNode head, int left, int right)
        {
            int l = 1;
            ListNode lNode = head;
            while (++l < left)
            {
                lNode = lNode.next;
            }

            var pre = lNode;
            var rNode = pre.next;
            var cur = pre.next;
            while (l++ <= right && cur != null)
            {
                var next = cur.next;

                cur.next = pre;
                pre = cur;
                cur = next;
            }

            if (cur != null)
            {
                lNode.next = pre;
                rNode.next = cur;
            }
            return head;
        }
    }
}
