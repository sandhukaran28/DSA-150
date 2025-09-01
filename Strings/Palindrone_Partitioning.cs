public class Solution
{
    IList<IList<string>> ans = new List<IList<string>>();
    public IList<IList<string>> Partition(string s)
    {
        List<string> ls = new List<string>();

        sol(s, 0, ls);

        return ans;
    }

    public void sol(string s, int idx, List<string> ls)
    {

        if (idx == s.Length)
        {
            ans.Add(new List<string>(ls));
        }

        for (int i = idx; i < s.Length; i++)
        {
            string str = s.Substring(idx, i - idx + 1);
            if (isPalindrone(str))
            {
                ls.Add(str);
                sol(s, i + 1, ls);
                ls.RemoveAt(ls.Count - 1);
            }
        }

    }

    public bool isPalindrone(string s)
    {
        int l = 0, r = s.Length - 1;
        while (l < r)
        {
            if (s[l] != s[r])
            {
                return false;
            }
            l++;
            r--;
        }

        return true;
    }
}