public class Solution
{
    public bool IsIsomorphic(string s, string t)
    {
        if (s.Length != t.Length)
        {
            return false;
        }
        int[] ch1 = new int[256];
        int[] ch2 = new int[256];

        for (int i = 0; i < s.Length; i++)
        {
            int c = s[i];
            int v = t[i];

            if (ch1[c] != ch2[v])
            {
                return false;
            }

            ch1[c] = i + 1;
            ch2[v] = i + 1;
        }
        return true;
    }
}