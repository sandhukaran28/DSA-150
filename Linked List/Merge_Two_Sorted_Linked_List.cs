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
    public ListNode MergeTwoLists(ListNode list1, ListNode list2)
    {
        ListNode start = new ListNode(0);
        ListNode pointer = start;

        while (list1 != null && list2 != null)
        {
            if (list1.val < list2.val)
            {
                pointer.next = list1;
                ListNode next = list1.next;
                list1.next = null;
                list1 = next;
            }
            else
            {
                pointer.next = list2;
                ListNode next = list2.next;
                list2.next = null;
                list2 = next;
            }
            pointer = pointer.next;
        }

        if (list1 != null)
        {
            pointer.next = list1;
        }
        else if (list2 != null)
        {
            pointer.next = list2;
        }

        return start.next;
    }
}