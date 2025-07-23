public class Solution
{
    List<List<int>> ans;
    public List<List<int>> SubsetsWithDup(int[] nums)
    {
        ans = new List<List<int>>();
        Array.Sort(nums);
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


        int curr = nums[index];
        ls.Add(curr);
        sol(nums, index + 1, ls);
        ls.RemoveAt(ls.Count - 1);
        while (index + 1 < nums.Length && nums[index] == nums[index + 1])
        {
            index++;
        }

        sol(nums, index + 1, ls);
    }
}
