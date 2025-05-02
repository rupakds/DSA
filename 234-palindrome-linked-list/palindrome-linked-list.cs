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
      if(head == null || head.next == null){
        return true;
      }  
      
      ListNode slow = head;
      ListNode fast = head;
      
      //finding the middle 
      while(fast != null && fast.next != null){
        slow = slow.next;
        fast = fast.next.next;
      }

      ListNode previous = null;
      //reverse the 2nd half 
      while(slow!= null){
        ListNode nextTemp = slow.next;
        slow.next = previous;
        previous = slow;
        slow = nextTemp;
      }
     
     ListNode firstHalf = head;
     ListNode secondHelf = previous;

     while(secondHelf != null){
        if(secondHelf.val != firstHalf.val){
            return false;
        }
        firstHalf = firstHalf.next;
        secondHelf = secondHelf.next;
     }
    return true;
    }
}