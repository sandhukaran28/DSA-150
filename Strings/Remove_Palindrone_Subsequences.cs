public class Solution
{
    public int RemovePalindromeSub(string s)
    {
        bool isPalindrone = true;

        int l = 0, r = s.Length - 1;
        while (l <= r)
        {
            if (s[l++] != s[r--])
            {
                isPalindrone = false;
                break;
            }
        }

        return isPalindrone ? 1 : 2;
    }
}