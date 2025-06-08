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
    public ListNode AddTwoNumbers(ListNode l1, ListNode l2)
    {
        int s1 = 0, s2 = 0;
        ListNode head1 = l1, head2 = l2;
        while (l1 != null)
        {
            s1++;
            l1 = l1.next;
        }
        while (l2 != null)
        {
            s2++;
            l2 = l2.next;
        }

        ListNode ans = s1 > s2 ? head1 : head2;
        l1 = head1;
        l2 = head2;
        int carry = 0;
        while (ans != null)
        {
            int sum = (l1 != null ? l1.val : 0) + (l2 != null ? l2.val : 0) + carry;
            carry = 0;
            ans.val = sum % 10;
            carry = sum / 10;

            if (ans.next == null)
            {
                break;
            }
            ans = ans.next;
            if (l1 != null)
            {
                l1 = l1.next;
            }
            if (l2 != null)
            {
                l2 = l2.next;
            }

        }

        if (carry > 0)
        {
            ans.next = new ListNode(carry);
        }

        return s1 > s2 ? head1 : head2;
    }
}
