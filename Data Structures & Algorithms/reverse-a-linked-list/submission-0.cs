public class Solution {
    public ListNode ReverseList(ListNode head) {
        ListNode prev = null;
        ListNode current = head;

        while (current != null) {
            ListNode next = current.next; // save next node
            current.next = prev;          // reverse pointer
            prev = current;               // move prev forward
            current = next;               // move current forward
        }

        return prev; // prev is the new head
    }
}