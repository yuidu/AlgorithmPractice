using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.LinkList
{
    public class ReverseLinkList
    {
        public ListNode ReverseList(ListNode head)
        {
            //pre, cur, next
            //      1->   2->3->4->5->6
            //       
            ListNode pre = null;
            var cur = head;
            while (cur != null)
            {
                var next = cur.next;
                cur.next = pre;
                pre = cur;
                cur = next;
            }
            return pre;
        }
    }
}
