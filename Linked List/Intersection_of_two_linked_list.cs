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
        HashSet<ListNode> hs = new HashSet<ListNode>();

        ListNode pointer = headA;
        while (pointer != null)
        {
            hs.Add(pointer);
            pointer = pointer.next;
        }

        while (headB != null)
        {
            if (hs.Contains(headB))
            {
                return headB;
            }
            headB = headB.next;
        }

        return null;
    }
}