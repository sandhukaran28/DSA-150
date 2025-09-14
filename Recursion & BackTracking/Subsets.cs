public class Solution
{
    IList<IList<int>> ans;
    public IList<IList<int>> Subsets(int[] nums)
    {
        ans = new List<IList<int>>();
        sol(nums, 0, new List<int>());
        return ans;
    }

    public void sol(int[] nums, int index, List<int> ls)
    {
        if (index == nums.Length)
        {
            ans.Add(new List<int>(ls));
            return;
        }
        //include
        ls.Add(nums[index]);
        sol(nums, index + 1, ls);

        ls.RemoveAt(ls.Count - 1);
        sol(nums, index + 1, ls);
        //backtrack
    }
}