public class Solution
{
    public int Rob(int[] nums)
    {
        int[] dp = new int[nums.Length];
        Array.Fill(dp, -1);
        int n1 = sol(nums, 0, 0, dp);
        Array.Fill(dp, -1);
        int n2 = sol(nums, 1, 1, dp);
        return Math.Max(n1, n2);
    }

    public int sol(int[] nums, int index, int start, int[] dp)
    {
        if (index >= nums.Length)
        {
            return 0;
        }
        if (index == nums.Length - 1 && nums.Length > 1 && start == 0)
        {
            return 0;
        }

        if (dp[index] != -1)
        {
            return dp[index];
        }

        int n1 = nums[index] + sol(nums, index + 2, start, dp);
        int n2 = sol(nums, index + 1, start, dp);

        return dp[index] = Math.Max(n1, n2);
    }
}
