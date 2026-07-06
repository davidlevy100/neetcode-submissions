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
    public ListNode MergeTwoLists(ListNode list1, ListNode list2)
    {
        // Dummy head (sentinel) — a throwaway node so the result list is never
        // "empty". Lets us attach unconditionally (no first-node special case).
        // `new()` is target-typed: the type comes from the declaration on the left.
        ListNode dummy = new();

        // Two cursors, one node to start: `dummy` stays frozen (we return its
        // `next` at the end); `tail` walks forward, always at the last attached node.
        ListNode tail = dummy;

        // Loop only while BOTH lists have a node — that's the only time there are
        // two vals to compare. The `&&` is deliberate: we exit the moment EITHER
        // runs out, leaving the other list fully intact for the tail-attach below.
        while (list1 is not null && list2 is not null)
        {
            // `<=` (not `<`) makes the merge stable: on a tie, list1's node goes first.
            if (list1.val <= list2.val)
            {
                tail.next = list1;
                list1 = list1.next;
            }
            else
            {
                tail.next = list2;
                list2 = list2.next;
            }
            tail = tail.next; // advance the result cursor onto the node just attached
        }

        // Exactly one list may still have nodes (or both are null). Those leftovers
        // are an already-sorted chain — attach the whole rest in one pointer assignment.
        // `??` (null-coalescing): use list1 unless it's null, then list2. Both null →
        // tail.next = null, which is harmless.
        tail.next = list1 ?? list2;

        // Skip the sentinel — the real merged head is dummy.next.
        return dummy.next;
    }
}