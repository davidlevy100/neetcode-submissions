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
    // Inverts (mirrors) a binary tree in place: every node's two children are swapped.
    // Recursion fits because the problem is self-similar — "invert a tree" = "swap the
    // children here, then invert each subtree". The code mirrors that definition almost word for word.
    // Signature is nullable (TreeNode?) because null is a real value here: an empty tree
    // inverts to an empty tree. That honesty is what lets the base case return null without a warning.
    // O(n) time (visits every node once); O(h) space for the call stack, where h is tree height.
    public TreeNode? InvertTree(TreeNode? root)
    {
        // Base case: a null node has no children to swap and nothing below to recurse into.
        // Hand null straight back up. This is also what makes the empty-tree test pass.
        if (root is null) return null;

        // Tuple swap (C# idiom) — the right-hand tuple is fully evaluated into a temporary
        // FIRST, then destructured into the left-hand side, so root.left isn't clobbered
        // before it's read. One line replaces the classic three-line temp-variable swap.
        (root.left, root.right) = (root.right, root.left);

        // Recurse into both sides. We IGNORE the return values on purpose: InvertTree mutates
        // the tree in place (the swap above already rewired this node), so by the time the calls
        // return, the subtrees are already fixed. Nothing to catch — fire and forget.
        // (Swapping BEFORE recursing also dodges the clobber bug you'd hit trying to swap via the returns.)
        InvertTree(root.left);
        InvertTree(root.right);

        // Return this node so the caller (and LeetCode's judge) gets the root of the inverted tree.
        return root;
    }
}
