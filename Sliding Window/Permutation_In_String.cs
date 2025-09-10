public class Solution
{
    public bool CheckInclusion(string s1, string s2)
    {
        int[] fre = new int[26];
        for (int i = 0; i < s1.Length; i++)
        {
            fre[s1[i] - 'a']++;
        }
        int k = s1.Length;
        int l = 0, r = 0, match = 0;
        while (r < s2.Length)
        {
            int idx = s2[r] - 'a';
            fre[idx]--;
            if (fre[idx] >= 0) match++;

            if (r - l + 1 > k)
            {
                int idxl = s2[l] - 'a';
                if (fre[idxl] >= 0)
                {
                    match--;
                }
                fre[idxl]++;
                l++;
            }

            if (match == k)
            {
                return true;
            }
            r++;
        }
        return false;
    }
}