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
    int max = 0;
    public int DiameterOfBinaryTree(TreeNode root)
    {
        int res = sol(root);
        return max;
    }

    public int sol(TreeNode root)
    {
        if (root == null)
        {
            return 0;
        }
        int left = sol(root.left);
        int right = sol(root.right);

        max = Math.Max(left + right, max);
        return Math.Max(left, right) + 1;


    }
}
