public class Solution {
    public ListNode DeleteDuplicates(ListNode head) {

       ListNode current = head;

       while(current != null &&  current.next != null){
            if(current.val == current.next.val){
               current.next = current.next.next;
            }else{
            current = current.next;
            }
        }
        return head;
    }
}