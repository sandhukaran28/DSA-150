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

public class Solution
{
    bool balanced = true;
    public bool IsBalanced(TreeNode root)
    {
        if (root == null)
        {
            return true;
        }
        int res = sol(root);
        return balanced;
    }

    public int sol(TreeNode root)
    {
        if (root == null)
        {
            return 0;
        }
        int left = sol(root.left);
        int right = sol(root.right);
        if (Math.Abs(left - right) > 1)
        {
            balanced = false;
        }

        return Math.Max(left, right) + 1;
    }
}
