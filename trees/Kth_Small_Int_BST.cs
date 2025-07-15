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
    int count = 0;
    int res = -1;
    public int KthSmallest(TreeNode root, int k)
    {
        sol(root, k);
        return res;
    }

    public void sol(TreeNode root, int k)
    {
        if (root == null || res != -1)
        {
            return;
        }
        sol(root.left, k);
        count++;
        if (count == k)
        {
            res = root.val;
            return;
        }

        sol(root.right, k);
    }

}
