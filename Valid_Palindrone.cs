public class Solution
{
    public bool IsPalindrome(string s)
    {
        int l = 0, r = s.Length - 1;
        while (l < r)
        {
            char left = Char.ToLower(s[l]);
            char right = Char.ToLower(s[r]);

            if (!((left >= 'a' && left <= 'z') || left >= '0' && left <= '9'))
            {
                l++;

                continue;
            }
            if (!((right >= 'a' && right <= 'z') || (right >= '0' && right <= '9')))
            {
                r--;

                continue;
            }
            if (left != right)
            {
                return false;
            }
            l++;
            r--;

        }

        return true;
    }
}