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
    public List<int> RightSideView(TreeNode root)
    {
        Queue<TreeNode> q = new Queue<TreeNode>();
        List<int> ls = new List<int>();
        if (root != null)
        {
            q.Enqueue(root);
        }

        while (q.Count > 0)
        {
            int count = q.Count;
            while (count > 0)
            {
                TreeNode curr = q.Dequeue();
                if (count == 1)
                {
                    ls.Add(curr.val);
                }
                if (curr.left != null)
                {
                    q.Enqueue(curr.left);
                }
                if (curr.right != null)
                {
                    q.Enqueue(curr.right);
                }
                count--;
            }
        }
        return ls;
    }
}
