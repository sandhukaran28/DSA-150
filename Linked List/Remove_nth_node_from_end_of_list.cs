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
    public ListNode RemoveNthFromEnd(ListNode head, int n)
    {
        ListNode fast = head;
        while (n > 0 && fast != null)
        {
            fast = fast.next;
            n--;
        }

        if (n > 0 || fast == null)
        {
            return head != null ? head.next : null;
        }
        ListNode temp = head;
        while (fast != null && fast.next != null)
        {
            head = head.next;
            fast = fast.next;
        }

        if (head.next != null)
        {
            head.next = head.next.next;
        }

        return temp;
    }
}