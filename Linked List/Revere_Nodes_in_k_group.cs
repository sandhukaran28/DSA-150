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
    public ListNode ReverseKGroup(ListNode head, int k)
    {
        // find length
        int n = 0;
        ListNode temp = head;
        while (temp != null)
        {
            temp = temp.next;
            n++;
        }

        int num = n / k;


        temp = head;

        ListNode dummy = null;
        ListNode last = null;

        
        while (num-- > 0)
        {
            int i = k;
            ListNode prev = null, first = temp;
            //actuak reverse
            while (i-- > 0 && temp != null)
            {
                ListNode next = temp.next;
                temp.next = prev;
                prev = temp;
                temp = next;
            }

            //just save head of first reversed part
            if (dummy == null)
            {
                dummy = prev;
            }
            //connect last part to current reversed part
            if (last != null)
            {
                last.next = prev;
            }
            last = first;

        }

        //connect remaining part
        if (temp != null)
        {
            last.next = temp;
        }

        return dummy;
    }
}