public class Solution
{
    public IList<int> FindAnagrams(string s, string p)
    {
        IList<int> ls = new List<int>();
        int[] arr1 = new int[26];
        int[] arr2 = new int[26];

        for (int i = 0; i < p.Length; i++)
        {
            arr1[p[i] - 'a']++;
        }

        int l = 0, r = 0;

        for (r = 0; r < s.Length; r++)
        {
            arr2[s[r] - 'a']++;

            if (r - l + 1 == p.Length)
            {
                bool isSame = true;
                for (int i = 0; i < 26; i++)
                {
                    if (arr1[i] != arr2[i])
                    {
                        isSame = false;
                        break;
                    }
                }
                if (isSame)
                {
                    ls.Add(l);
                }
                arr2[s[l] - 'a']--;
                l++;
            }
        }

        return ls;
    }
}