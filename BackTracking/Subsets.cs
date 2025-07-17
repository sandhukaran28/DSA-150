public class Solution
{
    List<List<int>> ans = new List<List<int>>();
    public List<List<int>> Subsets(int[] nums)
    {
        sol(nums, new List<int>(), 0);
        return ans;
    }

    public void sol(int[] nums, List<int> curr, int index)
    {
        if (index == nums.Length)
        {
            ans.Add(curr);
            return;
        }

        sol(nums, new List<int>(curr), index + 1);
        curr.Add(nums[index]);
        sol(nums, curr, index + 1);
    }
}
