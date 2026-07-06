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

    // Floyd's tortoise-and-hare — O(n) time, O(1) space
    // slow moves 1 step, fast moves 2. In a cycle, fast laps slow and they
    // collide; with no cycle, fast reaches the end (null) first.
    public bool HasCycle(ListNode head)
    {
        // Both start at head; fast does the dangerous two-hop each pass.
        ListNode slow = head;
        ListNode fast = head;

        // Guard the two references fast is about to follow, in order:
        //   fast       must be non-null to read fast.next
        //   fast.next  must be non-null to read fast.next.next
        // && short-circuits, so a null fast never reaches fast.next.
        // This also handles the empty list (head null → loop never runs → false),
        // so no separate `head is null` check is needed.
        while (fast is not null && fast.next is not null)
        {
            slow = slow.next;
            fast = fast.next.next;

            // Reference equality (== on ListNode = same object), NOT fast.val == slow.val.
            // We're asking "same node?", not "same value?" — duplicate values
            // (e.g. 1 → 2 → 1) would otherwise give a false positive.
            if (fast == slow)
            {
                return true;
            }
        }

        // fast ran off the end — the list is null-terminated, no cycle.
        return false;
    }
}
