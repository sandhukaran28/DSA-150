public class Solution
{
    public int Fib(int n)
    {
        int[] dp = new int[n + 1];
        Array.Fill(dp, -1);
        return sol(n, dp);
    }

    public int sol(int n, int[] dp)
    {
        if (dp[n] != -1)
        {
            return dp[n];
        }
        if (n < 0)
        {
            return 0;
        }

        if (n == 1 || n == 0)
        {
            return n;
        }
        int num = sol(n - 1, dp) + sol(n - 2, dp);
        return dp[n] = num;

    }
}