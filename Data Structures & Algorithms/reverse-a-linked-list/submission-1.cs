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
    // Iterative three-pointer reversal — O(n) time, O(1) space
    // Walk the list once, flipping each node's `next` to point backward
    public ListNode ReverseList(ListNode head)
    {
        // previous starts null — the original head becomes the new tail
        ListNode previous = null;
        ListNode nextNode;
        ListNode thisNode = head;

        // "is not null" — C# pattern matching syntax (preferred over != null)
        while (thisNode is not null)
        {
            // Save next before we overwrite it
            nextNode = thisNode.next;
            // Flip the pointer backward
            thisNode.next = previous;
            // Advance both pointers forward
            previous = thisNode;
            thisNode = nextNode;
        }

        // Loop exits when thisNode is null — previous holds the last node processed (new head)
        return previous;
    }
}
