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
    public int GoodNodes(TreeNode root)
    {
        if (root == null)
        {
            return 0;
        }
        return sol(root, root.val);
    }

    public int sol(TreeNode root, int max)
    {
        if (root == null)
        {
            return 0;
        }
        int cMax = Math.Max(max, root.val);
        int left = sol(root.left, cMax);
        int right = sol(root.right, cMax);
        return (root.val >= max ? 1 : 0) + left + right;


    }
}

