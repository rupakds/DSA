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
    public ListNode AddTwoNumbers(ListNode l1, ListNode l2) {
        
        int carry = 0;
        ListNode dummy = new ListNode(0);
        ListNode current = dummy;
         
         while(l1 != null || l2 != null || carry != 0){
            int val1 = (l1 != null) ? l1.val : 0;
            int val2 = (l2 != null) ? l2.val : 0;
            
            int sumValue = val1 + val2 + carry;
            carry = sumValue / 10;

          current.next = new ListNode(sumValue % 10);
          current = current.next;

           if (l1 != null) l1 = l1.next;
            if (l2 != null) l2 = l2.next;
         }

         return dummy.next;

    }
}