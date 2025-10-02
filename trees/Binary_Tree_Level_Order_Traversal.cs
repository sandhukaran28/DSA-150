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
    public IList<IList<int>> LevelOrder(TreeNode root)
    {
        Queue<TreeNode> que = new Queue<TreeNode>();
        IList<IList<int>> ans = new List<IList<int>>();
        if (root == null)
        {
            return ans;
        }

        que.Enqueue(root);
        while (que.Count > 0)
        {
            int count = que.Count;
            IList<int> curr = new List<int>();
            while (count-- > 0)
            {
                TreeNode node = que.Dequeue();
                curr.Add(node.val);
                if (node.left != null)
                {
                    que.Enqueue(node.left);
                }
                if (node.right != null)
                {
                    que.Enqueue(node.right);
                }
            }
            ans.Add(curr);


        }

        return ans;
    }
}