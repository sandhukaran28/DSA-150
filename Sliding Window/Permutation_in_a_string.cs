public class Solution
{
    public bool CheckInclusion(string s1, string s2)
    {
        Dictionary<char, int> dic = new Dictionary<char, int>();
        int[] count = new int[26];
        int[] count2 = new int[26];
        for (int i = 0; i < s1.Length; i++)
        {
            count[s1[i] - 'a']++;
        }

        int l = 0;
        for (int r = 0; r < s2.Length; r++)
        {
            char c = s2[r];
            count2[c - 'a']++;
            if (r - l + 1 == s1.Length)
            {

                for (int i = 0; i < 26; i++)
                {
                    if (count[i] != count2[i])
                    {
                        count2[s2[l] - 'a']--;
                        l++;
                        break;
                    }
                }
                if (r - l + 1 == s1.Length)
                {
                    return true;
                }

            }
        }

        return false;
    }
}
