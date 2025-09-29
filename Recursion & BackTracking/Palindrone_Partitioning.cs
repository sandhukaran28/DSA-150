public class Solution
{
    IList<IList<string>> ans = new List<IList<string>>();
    public IList<IList<string>> Partition(string s)
    {
        sol(s, 0, new List<string>());
        return ans;
    }


    // sol
    public void sol(string s, int l, List<string> ls)
    {
        if (l >= s.Length)
        {
            ans.Add(new List<string>(ls));
        }
        for (int i = l; i < s.Length; i++)
        {
            string sub = s.Substring(l, i - l + 1);
            if (isPalindrone(sub, 0, sub.Length - 1))
            {
                ls.Add(sub);
                sol(s, i + 1, ls);
                ls.RemoveAt(ls.Count - 1);
            }
        }
    }


    //check palindrone
    public bool isPalindrone(string s, int l, int r)
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