public class Solution
{
    IList<string> ans = new List<string>();
    public IList<string> LetterCombinations(string st)
    {
        if (st.Length > 0)
        {
            sol(st, 0, new StringBuilder());
        }
        return ans;
    }

    public void sol(string st, int idx, StringBuilder s)
    {
        if (idx == st.Length)
        {
            ans.Add(s.ToString());
            return;
        }
        int n = int.Parse(st.Substring(idx, 1));
        int start = (n - 2) * 3;
        if (n > 7)
        {
            start++;
        }

        int count = n == 7 || n == 9 ? 4 : 3;

        while (count-- > 0)
        {
            sol(st, idx + 1, s.Append((char)('a' + start)));
            s.Remove(s.Length - 1, 1);
            start++;
        }
    }
}