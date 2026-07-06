/**
 * Definition for a binary tree node.
 * public class TreeNode {
 *     public int val;
 *     public TreeNode left;
 *     public TreeNode right;
 *     public TreeNode(int val=0, TreeNode left=null, TreeNode right=null) {
 *         this.val = val;
 *         this.left = left;
 *         this.right = right;
 *     }
 * }
 */

public class Solution {
    // Recursive simultaneous traversal — O(n) time, O(h) call-stack space
    public bool IsSameTree(TreeNode p, TreeNode q)
    {
        // Base case: both null = both subtrees ended at the same depth
        if (p is null && q is null) return true;

        // Both non-null with matching values: recurse into children
        // Short-circuits via &&: if left subtrees differ, right is never checked
        if (p is not null && q is not null && p.val == q.val)
            return IsSameTree(p.left, q.left) && IsSameTree(p.right, q.right);

        // Catch-all: one is null (structural mismatch) or values differ
        return false;
    }
}
