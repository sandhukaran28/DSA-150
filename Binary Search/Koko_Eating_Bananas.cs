public class Solution
{
    public int MinEatingSpeed(int[] piles, int h)
    {
        int r = 0;
        int n = piles.Length;
        for (int i = 0; i < n; i++)
        {
            r = Math.Max(r, piles[i]);
        }


        int l = 1, ans = int.MaxValue;
        while (l <= r)
        {
            int mid = (l + r) / 2;
            if (isValid(piles, mid, h))
            {
                ans = mid;
                r = mid - 1;
            }
            else
            {
                l = mid + 1;
            }

        }

        return ans;
    }

    public bool isValid(int[] piles, int k, int h)
    {
        for (int i = 0; i < piles.Length; i++)
        {
            double curr = Math.Ceiling((double)piles[i] / k);
            h -= (int)curr;
            if (h < 0)
            {
                break;
            }
        }

        return h >= 0 ? true : false;
    }
}