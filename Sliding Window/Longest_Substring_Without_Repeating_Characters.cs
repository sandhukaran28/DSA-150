public class Solution
{
    public int LengthOfLongestSubstring(string s)
    {
        Dictionary<char, int> dic = new Dictionary<char, int>();
        int l = 0, max = s.Length > 0 ? 1 : 0;
        for (int i = 0; i < s.Length; i++)
        {
            if (dic.ContainsKey(s[i]) && dic[s[i]] >= l)
            {
                l = dic[s[i]] + 1;
            }

            dic[s[i]] = i;
            max = Math.Max(i - l + 1, max);
        }

        return max;
    }
}

public class Solution
{
    public int LengthOfLongestSubstring(string s)
    {
        if (s.Length == 0 || s.Length == 1)
        {
            return s.Length;
        }
        Dictionary<char, int> dic = new Dictionary<char, int>();
        int l = 0, r = 0, ans = 0;
        while (r < s.Length)
        {
            char ch = s[r];
            if (dic.ContainsKey(ch))
            {
                int idx = dic[ch];
                while (l <= idx)
                {
                    dic.Remove(ch);
                    l++;
                }
            }
            dic[ch] = r;
            ans = Math.Max(ans, r - l + 1);

            r++;
        }

        return ans;
    }
}
