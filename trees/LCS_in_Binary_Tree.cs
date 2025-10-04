/**
 * Definition for a binary tree node.
 * public class TreeNode {
 *     public int val;
 *     public TreeNode left;
 *     public TreeNode right;
 *     public TreeNode(int x) { val = x; }
 * }
 */

public class Solution
{
    public TreeNode LowestCommonAncestor(TreeNode root, TreeNode p, TreeNode q)
    {
        TreeNode curr = root;
        int pv = p.val;
        int qv = q.val;
        while (curr != null)
        {
            if (p.val < curr.val && q.val < curr.val)
            {
                curr = curr.left;
            }
            else if (p.val > curr.val && q.val > curr.val)
            {
                curr = curr.right;
            }
            else
            {
                return curr;
            }
        }

        return null;
    }
}