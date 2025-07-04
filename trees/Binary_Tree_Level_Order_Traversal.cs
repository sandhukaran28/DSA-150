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
    public List<List<int>> LevelOrder(TreeNode root)
    {
        List<List<int>> list = new List<List<int>>();
        Queue<TreeNode> queue = new Queue<TreeNode>();
        if (root != null)
        {
            queue.Enqueue(root);
        }

        while (queue.Count > 0)
        {
            int size = queue.Count;
            List<int> ls = new List<int>();
            for (int i = 0; i < size; i++)
            {
                TreeNode current = queue.Dequeue();
                ls.Add(current.val);
                if (current.left != null)
                {
                    queue.Enqueue(current.left);
                }
                if (current.right != null)
                {
                    queue.Enqueue(current.right);
                }
            }

            list.Add(ls);

        }

        return list;
    }
}
