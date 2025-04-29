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
    public ListNode RemoveElements(ListNode head, int val) {
        
        while(head != null && head.val == val){
            head = head.next;
        }

        ListNode current = head;

        while(current != null && current.next != null){
           if(current.next.val == val){
              current.next = current.next.next; //skip the node
           }else{
            current = current.next; // Only move forward if no deletion
           }

        }
        

        return head;
    }
}