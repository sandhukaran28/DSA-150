public class Solution
{
    IList<string> ans = new List<string>();
    public IList<string> GenerateParenthesis(int n)
    {
        sol(new StringBuilder(), n, n);
        return ans;
    }

    public void sol(StringBuilder sb, int open, int close)
    {

        if (open == 0 && close == 0)
        {
            ans.Add(sb.ToString());
            return;
        }

        if (open > 0)
        {
            sb.Append('(');
            sol(sb, open - 1, close);
            sb.Remove(sb.Length - 1, 1);
        }

        if (close > 0 && close > open)
        {
            sb.Append(')');
            sol(sb, open, close - 1);
            sb.Remove(sb.Length - 1, 1);

        }
    }
}