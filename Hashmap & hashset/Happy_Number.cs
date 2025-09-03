public class Solution
{
    public bool IsHappy(int n)
    {
        HashSet<int> hs = new HashSet<int>();

        while (n != 1)
        {
            int curr = 0;
            while (n > 0)
            {
                int last = n % 10;
                curr += (last * last);
                n /= 10;
            }
            if (hs.Contains(curr))
            {
                return false;
            }
            hs.Add(curr);
            n = curr;
        }

        return true;
    }
}