public class Solution
{
    public int CharacterReplacement(string s, int k)
    {
        Dictionary<char, int> dic = new Dictionary<char, int>();
        int l = 0, max = 0, maxLength = 0;
        for (int r = 0; r < s.Length; r++)
        {
            if (!dic.ContainsKey(s[r]))
            {
                dic[s[r]] = 0;
            }
            dic[s[r]]++;
            max = Math.Max(max, dic[s[r]]);
            if ((r - l + 1) - max > k)
            {
                dic[s[l]]--;
                l++;
            }

            maxLength = Math.Max(maxLength, r - l + 1);

        }
        return maxLength;
    }

}
