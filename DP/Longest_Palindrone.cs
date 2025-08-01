public class Solution
{
    public string LongestPalindrome(string s)
    {
        int start = 0, maxLen = 0;
        for (int i = 0; i < s.Length; i++)
        {

            traverse(s, i, i, ref start, ref maxLen);

            traverse(s, i, i + 1, ref start, ref maxLen);
        }

        return s.Substring(start, maxLen);
    }

    public void traverse(string s, int l, int r, ref int start, ref int maxLen)
    {
        while (l >= 0 && r < s.Length)
        {
            if (s[l] == s[r])
            {
                int len = r - l + 1;
                if (len > maxLen)
                {
                    start = l;
                    maxLen = len;

                }
                l--;
                r++;
            }
            else
            {
                break;
            }

        }
    }
}
