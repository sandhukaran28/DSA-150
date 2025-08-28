public class Solution
{
    public bool ArrayStringsAreEqual(string[] word1, string[] word2)
    {
        string s = "";
        string t = "";

        for (int i = 0; i < word1.Length; i++)
        {
            s += word1[i];
        }
        for (int i = 0; i < word2.Length; i++)
        {
            t += word2[i];
        }

        if (s.Length != t.Length)
        {
            return false;
        }

        for (int i = 0; i < s.Length; i++)
        {
            if (s[i] != t[i])
            {
                return false;
            }
        }

        return true;

    }
}