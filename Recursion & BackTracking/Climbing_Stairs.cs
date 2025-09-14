public class Solution
{
    public int ClimbStairs(int n)
    {
        int[] dp = new int[n + 1];
        Array.Fill(dp, -1);
        return sol(n, dp);
    }

    public int sol(int n, int[] dp)
    {



        if (n == 0)
        {
            return 1;
        }
        else if (n < 0)
        {
            return 0;
        }
        if (dp[n] != -1)
        {
            return dp[n];
        }
        int curr = sol(n - 1, dp) + sol(n - 2, dp);

        return dp[n] = curr;
    }
}