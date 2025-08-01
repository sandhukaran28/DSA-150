public class Solution
{
    public int NumDecodings(string s)
    {
        int[] dp = new int[s.Length];
        Array.Fill(dp, -1);
        return sol(s, 0, dp);

    }

    public int sol(string s, int index, int[] dp)
    {
        if (index >= s.Length)
        {
            return 1;
        }
        if (s[index] == '0')
        {
            return 0;
        }
        if (dp[index] != -1)
        {
            return dp[index];
        }

        int c1 = 0, c2 = 0;
        int s1 = int.Parse(s.Substring(index, 1));
        if (s1 >= 1 && s1 <= 26)
        {
            c1 = sol(s, index + 1, dp);
        }
        if (index <= s.Length - 2)
        {
            int s2 = int.Parse(s.Substring(index, 2));
            if (s2 >= 1 && s2 <= 26)
            {
                c2 = sol(s, index + 2, dp);
            }
        }


        return dp[index] = c1 + c2;


    }
}
