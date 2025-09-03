public class Solution
{
    public bool IsIsomorphic(string s, string t)
    {
        Dictionary<char, char> map1 = new Dictionary<char, char>();
        Dictionary<char, char> map2 = new Dictionary<char, char>();

        for (int i = 0; i < s.Length; i++)
        {
            if (!map1.ContainsKey(s[i]) && !map2.ContainsKey(t[i]))
            {
                map1[s[i]] = t[i];
                map2[t[i]] = s[i];
            }
            else
            {
                if (map1.ContainsKey(s[i]) && map2.ContainsKey(t[i]))
                {
                    if (map1[s[i]] != t[i] || map2[t[i]] != s[i])
                    {
                        return false;
                    }
                }
                else
                {
                    return false;
                }
            }


        }
        return true;
    }
}