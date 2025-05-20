public class Solution
{
    public bool IsAnagram(string s, string t)
    {
        if (s.Length != t.Length)
        {
            return false;
        }
        int[] freq = new int[26];
        int count = 0;
        for (int i = 0; i < s.Length; i++)
        {
            freq[s[i] - 'a']++;
            count++;
        }

        for (int i = 0; i < t.Length; i++)
        {
            if (freq[t[i] - 'a'] > 0)
            {
                freq[t[i] - 'a']--;
                count--;
            }
            else
            {
                return false;
            }
        }

        return count == 0 ? true : false;
    }
}