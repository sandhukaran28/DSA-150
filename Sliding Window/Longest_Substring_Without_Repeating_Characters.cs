public class Solution {
    public int LengthOfLongestSubstring(string s) {
        Dictionary<char,int> dic = new Dictionary<char,int>();
        int  l = 0, ans = 0;
        for(int r = 0;r< s.Length;r++){
            char ch = s[r];
            if(dic.ContainsKey(ch)){
                 if(dic[ch] >= l){
                   l = dic[ch]+1;
                }

            }
            dic[ch] = r;
            ans = Math.Max(r-l+1, ans);
        }

        return ans;
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
