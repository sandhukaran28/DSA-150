public class Solution
{
    public int MinCostClimbingStairs(int[] cost)
    {
        int[] dp = new int[cost.Length];
        for (int i = 0; i < cost.Length; i++)
        {
            dp[i] = -1;
        }
        return Math.Min(sol(cost, 1, dp), sol(cost, 0, dp));
    }

    public int sol(int[] cost, int index, int[] dp)
    {
        if (index >= cost.Length)
        {
            return 0;
        }
        if (dp[index] != -1)
        {
            return dp[index];
        }
        int n1 = sol(cost, index + 1, dp);
        int n2 = sol(cost, index + 2, dp);

        return dp[index] = cost[index] + Math.Min(n1, n2);
    }
}
