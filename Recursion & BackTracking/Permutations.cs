public class Solution
{
    List<List<int>> ans;
    HashSet<int> hs;
    public List<List<int>> Permute(int[] nums)
    {
        ans = new List<List<int>>();
        hs = new HashSet<int>();
        sol(nums, new List<int>());

        return ans;
    }

    public void sol(int[] nums, List<int> ls)
    {
        if (ls.Count == nums.Length)
        {
            ans.Add(new List<int>(ls));
            return;
        }

        for (int i = 0; i < nums.Length; i++)
        {
            if (!hs.Contains(nums[i]))
            {
                hs.Add(nums[i]);
                ls.Add(nums[i]);
                sol(nums, ls);
                ls.RemoveAt(ls.Count - 1);
                hs.Remove(nums[i]);
            }
        }
    }
}
