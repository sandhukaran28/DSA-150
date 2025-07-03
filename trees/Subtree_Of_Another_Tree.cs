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
    bool isSame = false;
    public bool IsSubtree(TreeNode root, TreeNode subRoot)
    {
        sol(root, subRoot);
        return isSame;
    }
    public void sol(TreeNode root, TreeNode subRoot)
    {
        if (root == null || subRoot == null)
        {
            return;
        }

        if (!isSame && root.val == subRoot.val)
        {
            isSame = subTree(root, subRoot);
        }
        sol(root.left, subRoot);
        sol(root.right, subRoot);
    }

    public bool subTree(TreeNode root, TreeNode subRoot)
    {
        if (root == null && subRoot == null)
        {
            return true;
        }
        else if (root == null || subRoot == null)
        {
            return false;
        }

        if (root.val != subRoot.val)
        {
            return false;
        }

        bool left = subTree(root.left, subRoot.left);
        bool right = subTree(root.right, subRoot.right);

        return left && right;
    }
}
