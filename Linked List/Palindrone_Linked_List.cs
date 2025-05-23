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
    public bool IsPalindrome(ListNode head)
    {
        if (head.next == null)
        {
            return true;
        }
        ListNode fast = head, start = head;
        //find mid
        while (fast != null && fast.next != null)
        {
            start = start.next;
            fast = fast.next.next;
        }

        //reverse from mid to end
        ListNode prev = null, next = null;
        while (start != null)
        {
            next = start.next;
            start.next = prev;
            prev = start;
            start = next;
        }
        while (prev != null && head != null)
        {
            if (prev.val != head.val)
            {
                return false;
            }
            prev = prev.next;
            head = head.next;

        }
        return true;
    }
}