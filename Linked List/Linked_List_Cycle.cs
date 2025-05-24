/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int x) {
 *         val = x;
 *         next = null;
 *     }
 * }
 */
public class Solution
{
    public bool HasCycle(ListNode head)
    {
        ListNode fast = head;
        while (head != null && fast != null && fast.next != null)
        {
            head = head.next;
            fast = fast.next.next;
            if (fast != null && head.next != null && head == fast)
            {
                return true;
            }

        }

        return false;
    }
}