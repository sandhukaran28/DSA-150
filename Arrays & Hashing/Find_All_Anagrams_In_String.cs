public class Solution
{
    public IList<int> FindAnagrams(string s, string p)
    {
        int[] arr = new int[26];
        for (int i = 0; i < p.Length; i++)
        {
            arr[p[i] - 'a']++;
        }

        IList<int> ls = new List<int>();
        int l = 0, r = 0, match = 0;

        while (r < s.Length)
        {
            if (arr[s[r] - 'a'] > 0)
            {
                match++;
            }
            arr[s[r] - 'a']--;
            r++;
            if (match == p.Length)
            {
                ls.Add(l);
            }
            if (r - l == p.Length)
            {
                int idx = s[l] - 'a';
                if (arr[idx] >= 0)
                {
                    match--;
                }
                arr[idx]++;
                l++;

            }
        }

        return ls;
    }
}