using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.LinkList
{
    public class CreateLinkList
    {
        public ListNode Create(int[] list, int n)
        {
            ListNode head = null;
            if (n > 0)
                head = new ListNode(list[0],null);

            var pre = head;
            for (var i = 0; i < list.Length; i++)
            {
                pre.next = new ListNode(list[i], null);
                pre = pre.next;
            }

            return head;
        }
    }
}
