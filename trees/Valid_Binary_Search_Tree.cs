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
    public bool IsValidBST(TreeNode node)
    {
        if (node == null)
        {
            return true;
        }

        return sol(node, long.MinValue, long.MaxValue);
    }

    public bool sol(TreeNode node, long left, long right)
    {
        if (node == null)
        {
            return true;
        }

        if (node.val <= left || node.val >= right)
        {
            return false;
        }

        return sol(node.left, left, node.val) && sol(node.right, node.val, right);



    }
}