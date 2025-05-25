/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int x) { val = x; }
 * }
 */
public class Solution
{
    public ListNode GetIntersectionNode(ListNode headA, ListNode headB)
    {
        int count1 = 0, count2 = 0;
        ListNode pointer = headA;
        while (pointer != null)
        {
            count1++;
            pointer = pointer.next;
        }
        pointer = headB;
        while (pointer != null)
        {
            count2++;
            pointer = pointer.next;
        }
        if (count1 > count2)
        {
            int diff = count1 - count2;
            while (diff-- > 0)
            {
                headA = headA.next;
            }
        }
        else if (count2 > count1)
        {
            int diff = count2 - count1;
            while (diff-- > 0)
            {
                headB = headB.next;
            }
        }

        while (headA != null && headB != null)
        {
            if (headA == headB)
            {
                return headA;
            }
            headA = headA.next;
            headB = headB.next;
        }

        return null;
    }
}