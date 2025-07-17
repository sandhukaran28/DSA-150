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
    int index = 0;
    public TreeNode BuildTree(int[] preorder, int[] inorder)
    {
        Dictionary<int, int> dic = new Dictionary<int, int>();
        for (int i = 0; i < inorder.Length; i++)
        {
            dic.Add(inorder[i], i);
        }

        return sol(preorder, inorder, dic, 0, inorder.Length - 1);


    }

    public TreeNode sol(int[] preorder, int[] inorder, Dictionary<int, int> dic, int l, int r)
    {
        if (r < l)
        {
            return null;
        }

        TreeNode root = new TreeNode(preorder[index++]);
        int inIndex = dic[root.val];
        root.left = sol(preorder, inorder, dic, l, inIndex - 1);
        root.right = sol(preorder, inorder, dic, inIndex + 1, r);
        return root;
    }
}
