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
    public int DiameterOfBinaryTree(TreeNode root)
    {
        // Local helper returns a tuple: (depth of this subtree, best diameter in it).
        // static because it captures nothing — all state flows through the return
        // value (the tuple), so it's a pure function. The tuple route is the
        // no-mutable-state alternative to a captured field/closure counter.
        static (int depth, int diameter) Depth(TreeNode? node)
        {
            // Base case: an empty subtree has 0 depth and 0 diameter. This guards
            // `node` (the thing that varies per call) — NOT the outer `root`.
            if (node is null) return (0, 0);

            // Deconstruct each child's (depth, diameter) into named locals.
            var (leftDepth, leftDia) = Depth(node.left);
            var (rightDepth, rightDia) = Depth(node.right);

            // This subtree's depth = 1 + deeper child (same shape as MaxDepth).
            int thisDepth = 1 + Math.Max(leftDepth, rightDepth);

            // Best diameter here = largest of three: best-on-the-left, best-on-the-
            // right, and the path THROUGH this node (leftDepth + rightDepth edges).
            // Math.Max takes two args, so nest it for the three-way compare.
            int thisDiam = Math.Max(leftDepth + rightDepth, Math.Max(leftDia, rightDia));

            return (thisDepth, thisDiam);
        }

        // Kick off the recursion; discard the depth (_), keep only the diameter.
        (int _, int diameter) = Depth(root);

        return diameter;
    }
}
