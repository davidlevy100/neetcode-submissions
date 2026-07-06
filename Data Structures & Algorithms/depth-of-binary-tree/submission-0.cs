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

    // Recursive depth: a tree's depth is 1 (this node) + the depth of its
    // deeper subtree. O(n) time (visits every node once), O(h) call-stack space.
    public int MaxDepth(TreeNode root)
    {
        // Base case: the null node contributes 0 depth. An empty tree is a real
        // input, which is why the parameter is TreeNode? — same nullable choice
        // as InvertBinaryTree, so FromList -> MaxDepth lines up with no warnings.
        if (root is null) return 0;

        // Recurse into both sides, keep the deeper one, add this level.
        // Math.Max over a manual if — the idiomatic C# way to pick the larger.
        return 1 + Math.Max(MaxDepth(root.left), MaxDepth(root.right));
    }
}
