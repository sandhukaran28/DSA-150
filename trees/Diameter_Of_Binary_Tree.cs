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
    int ans = 0;
    public int DiameterOfBinaryTree(TreeNode root)
    {
        recursion(root);
        return ans;
    }

    public int recursion(TreeNode node)
    {
        if (node == null)
        {
            return 0;
        }

        int left = recursion(node.left);
        int right = recursion(node.right);

        ans = Math.Max(left + right, ans);

        return Math.Max(left, right) + 1;
    }

}