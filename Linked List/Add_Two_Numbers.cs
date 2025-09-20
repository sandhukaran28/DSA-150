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
        int n1 = 0, n2 = 0;
        ListNode head = l1;
        while (head != null)
        {
            n1++;
            head = head.next;
        }
        head = l2;
        while (head != null)
        {
            n2++;
            head = head.next;
        }
        if (n1 >= n2)
        {
            head = l1;
        }
        else
        {
            head = l2;
        }

        ListNode temp = head;
        int sum = 0;
        while (head != null)
        {
            if (l1 != null)
            {
                sum += l1.val;
                l1 = l1.next;
            }
            if (l2 != null)
            {
                sum += l2.val;
                l2 = l2.next;
            }

            head.val = sum % 10;
            sum = sum / 10;
            if (head.next != null)
            {
                head = head.next;
            }
            else
            {
                break;
            }
        }

        if (sum > 0)
        {
            head.next = new ListNode(sum);
        }

        return temp;


    }
}