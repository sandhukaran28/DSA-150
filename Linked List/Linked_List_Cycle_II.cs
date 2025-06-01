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
    public ListNode DetectCycle(ListNode head)
    {
        ListNode slow = head, fast = head;
        while (fast != null && fast.next != null)
        {
            slow = slow.next;
            fast = fast.next.next;
            if (slow != null && fast != null && slow == fast)
            {
                break;
            }
        }

        if (fast == null || fast.next == null)
        {
            return null;
        }
        else
        {
            while (fast != null && head != null && fast != head)
            {
                fast = fast.next;
                head = head.next;
            }

            return head;
        }
    }
}