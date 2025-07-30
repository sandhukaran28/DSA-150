public class Solution
{
    public int Rob(int[] nums)
    {
        int[] dp = new int[nums.Length];
        for (int i = 0; i < nums.Length; i++)
        {
            dp[i] = -1;
        }

        return sol(nums, 0, dp);
    }

    public int sol(int[] nums, int index, int[] dp)
    {
        if (index >= nums.Length)
        {
            return 0;
        }
        if (dp[index] != -1)
        {
            return dp[index];
        }
        int n1 = nums[index] + sol(nums, index + 2, dp);
        int n2 = sol(nums, index + 1, dp);

        return dp[index] = Math.Max(n1, n2);
    }
}
