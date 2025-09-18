/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int val=0, ListNode next=null) {
 *         this.val = val;
 *         this.next = next;
 *     }
 * }
 */
public class Solution
{
    public ListNode MergeTwoLists(ListNode l1, ListNode l2)
    {
        ListNode dummy = new ListNode(0);
        ListNode head = dummy;
        while (l1 != null || l2 != null)
        {
            if (l1 != null && l2 != null)
            {
                if (l1.val < l2.val)
                {
                    dummy.next = l1;
                    l1 = l1.next;
                }
                else
                {
                    dummy.next = l2;
                    l2 = l2.next;
                }

            }
            else if (l1 != null)
            {
                dummy.next = l1;
                l1 = l1.next;
            }
            else
            {
                dummy.next = l2;
                l2 = l2.next;
            }
            dummy = dummy.next;
        }

        return head.next;
    }
}