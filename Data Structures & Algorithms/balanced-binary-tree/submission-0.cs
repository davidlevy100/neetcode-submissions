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
    // TreeNode? (nullable) because null — the empty tree — is a real, valid input
    // and it IS balanced. Honest signature over `TreeNode root` + `node!` suppression;
    // also clears the CS8604 the tests raised by passing FromList's TreeNode? result.
    public bool IsBalanced(TreeNode root)
    {
        // Local function: the recursive helper, private to this method. `static` because
        // it captures no enclosing locals — all state flows through the params/return, so
        // it's a pure helper (no closure allocation). Two problems fused: it RETURNS depth
        // (parents need it to compare their two sides) but the ANSWER we want is `balanced`,
        // carried alongside in a tuple.
        static (int depth, bool balanced) Check(TreeNode node)
        {
            // Base case: empty subtree is depth 0 and trivially balanced.
            if (node is null) return (0, true);

            // Deconstruct each child's tuple into locals in one line.
            var (leftDepth, leftBal) = Check(node.left);
            var (rightDepth, rightBal) = Check(node.right);

            // "+ 1" counts THIS level (same shape as MaxDepth). Dropping it makes every
            // node report 0 → every |diff| is 0 ≤ 1 → everything reports balanced.
            int thisDepth = 1 + Math.Max(leftDepth, rightDepth);

            // Per-node check, not root-only: children must BOTH be balanced (leftBal && rightBal)
            // AND this node's two heights differ by ≤ 1. `&&` short-circuits, so a false from
            // any subtree rides straight to the root — the built-in version of a `-1` sentinel.
            bool isBalanced = leftBal && rightBal && Math.Abs(leftDepth - rightDepth) <= 1;

            return (thisDepth, isBalanced);
        }

        // We only want the bool — discard the depth with `_`.
        (int _, bool balanced) = Check(root);

        return balanced;
    }
}
