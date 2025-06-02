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
        if (head == null || head.next == null)
        {
            return null;
        }
        ListNode slow = head, fast = head;
        for (int i = 1; i <= n; i++)
        {
            fast = fast.next;
        }
        if (fast == null)
        {
            head = head.next;
        }

        while (fast != null && fast.next != null)
        {
            slow = slow.next;
            fast = fast.next;
        }
        if (slow.next != null)
        {
            slow.next = slow.next.next;
        }

        return head;
    }
}