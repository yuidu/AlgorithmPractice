/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int x) { val = x; }
 * }
 */
 
  public class ListNode {
    public int val;
    public ListNode next;
    public ListNode(int x) { val = x; } 
  }

 
 public class AddTwoNumbersCL {
    public ListNode AddTwoNumbers(ListNode l1, ListNode l2) {
        var p = l1;
        var q = l2;
        
        var k = 0;
        ListNode head = null;
        ListNode parent = null;
        while (p!= null || q!= null )
        {
            ListNode lNode;
            
            if (p == null && q != null)
            {                
                lNode = new ListNode(q.val + k);
                k = 0;
            }
            else if (q == null && p != null)
            {
                lNode = new ListNode(p.val + k);                
                k = 0;
            }
            else
            {
                var sum = 0;
                if (p.val + q.val >= 10 )
                {
                    k = (p.val + q.val)/10;
                    sum = ((p.val + q.val) % 10);
                }
                else
                {
                    sum = p.val + q.val;
                    k = 0;
                }
                
                lNode = new ListNode(sum);                 
            }
            
            if (head == null)
            {
                head = lNode;      
                parent = lNode;
            }        
            else
            {
                parent.next = lNode;                            
                parent = lNode;      
            }            

            p = p.next;
            q = q.next;   
        }
        return head;
    }
}