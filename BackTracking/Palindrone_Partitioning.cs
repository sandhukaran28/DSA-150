public class Solution
{
    List<List<string>> ans;
    public List<List<string>> Partition(string s)
    {
        ans = new List<List<string>>();
        sol(s, 0, new List<String>());
        return ans;
    }

    public void sol(string s, int l, List<string> ls)
    {
        if (l == s.Length)
        {
            ans.Add(new List<string>(ls));
            return;
        }

        for (int r = l; r < s.Length; r++)
        {
            bool check = checkPalindrone(s, l, r);
            if (check)
            {
                ls.Add(s.Substring(l, r - l + 1));
                sol(s, r + 1, ls);
                ls.RemoveAt(ls.Count - 1);

            }
        }

    }

    public bool checkPalindrone(string s, int l, int r)
    {

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
