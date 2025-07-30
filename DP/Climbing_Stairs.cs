public class Solution
{
    public int ClimbStairs(int n)
    {
        int[] dp = new int[n + 1];
        for (int i = 0; i <= n; i++)
        {
            dp[i] = -1;
        }

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

        int n1 = sol(n - 1, dp);
        int n2 = sol(n - 2, dp);

        return dp[n] = n1 + n2;
    }
}
