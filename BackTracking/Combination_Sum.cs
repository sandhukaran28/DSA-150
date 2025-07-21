public class Solution
{
    List<List<int>> ans;
    public List<List<int>> CombinationSum(int[] nums, int target)
    {
        ans = new List<List<int>>();
        sol(nums, 0, target, new List<int>());
        return ans;
    }

    public void sol(int[] nums, int index, int target, List<int> ls)
    {
        Console.WriteLine("t: " + target);


        if (target == 0)
        {
            ans.Add(new List<int>(ls));
            return;
        }
        else if (target < 0)
        {
            return;
        }

        if (index == nums.Length)
        {
            return;
        }
        ls.Add(nums[index]);
        sol(nums, index, target - nums[index], ls);
        ls.RemoveAt(ls.Count - 1);
        sol(nums, index + 1, target, ls);
    }
}
