public class Solution
{
    public bool CheckPalindromeFormation(string a, string b)
    {
        return sol(a, b) || sol(b, a);
    }

    public bool sol(string a, string b)
    {
        int l = 0, r = b.Length - 1;
        while (l < r && a[l] == b[r])
        {
            l++;
            r--;
        }

        if (l >= r)
        {
            return true;
        }

        return isPal(a, l, r) || isPal(b, l, r);


    }

    public bool isPal(string s, int l, int r)
    {
        while (l < r)
        {
            if (s[l] != s[r])
            {
                return false;
            }
            l++;
            r--;
        }

        return true;
    }
}