public class Solution
{
    public int CountCollisions(string directions)
    {
        int l = 0, r = directions.Length - 1, count = 0;
        while (l <= r && directions[l] == 'L')
        {
            l++;
        }
        while (r >= 0 && directions[r] == 'R')
        {
            r--;
        }

        while (l <= r)
        {
            if (directions[l] != 'S')
            {
                count++;
            }

            l++;
        }
        return count;

    }
}