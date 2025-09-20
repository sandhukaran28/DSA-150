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
public class Solution {
    public bool IsPalindrome(ListNode head) {
       ListNode slow = head, fast = head;
       while(fast != null && fast.next != null){
        fast = fast.next.next;
        slow = slow.next;
       } 

       ListNode prev = null;

       while(slow != null){
        ListNode next = slow.next;
        slow.next = prev;
        prev = slow;
        slow = next;
       }
        slow = prev;
        while(slow != null && head != null){
            if(slow.val != head.val){
                return false;
            }
            head = head.next;
            slow = slow.next;
        }

        return true;
    
    
    }
}