public class Solution
{
    public bool CanConstruct(string t, string s)
    {
        int[] fre = new int[26];
        for (int i = 0; i < s.Length; i++)
        {
            fre[s[i] - 'a']++;
        }
        for (int i = 0; i < t.Length; i++)
        {
            fre[t[i] - 'a']--;
        }

        for (int i = 0; i < 26; i++)
        {
            if (fre[i] < 0)
            {
                return false;
            }
        }

        return true;
    }
}