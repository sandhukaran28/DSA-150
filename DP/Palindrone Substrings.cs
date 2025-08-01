public class Solution
{
    public int CountSubstrings(string s)
    {
        int count = 0;
        for (int i = 0; i < s.Length; i++)
        {
            int c1 = traverse(s, i, i);
            int c2 = traverse(s, i, i + 1);

            count += (c1 + c2);
        }

        return count;
    }

    public int traverse(string s, int l, int r)
    {
        int count = 0;
        while (l >= 0 && r < s.Length)
        {
            if (s[l] == s[r])
            {
                count++;
                l--;
                r++;
            }
            else
            {
                break;
            }
        }

        return count;

    }
}
