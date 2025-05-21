public class Solution
{
    public string MinWindow(string s, string t)
    {
        Dictionary<char, int> dic = new Dictionary<char, int>();
        for (int i = 0; i < t.Length; i++)
        {
            if (!dic.ContainsKey(t[i]))
            {
                dic[t[i]] = 0;
            }
            dic[t[i]]++;
        }

        Dictionary<char, int> dic2 = new Dictionary<char, int>();
        int count = 0, min = 10000000, l = 0;
        string str = "";
        for (int r = 0; r < s.Length; r++)
        {
            char c = s[r];


            if (!dic2.ContainsKey(c))
            {
                dic2[c] = 0;
            }
            dic2[c]++;
            if (dic.ContainsKey(c) && dic[c] == dic2[c])
            {
                count++;
            }

            while (count == dic.Count)
            {
                if (r - l + 1 < min)
                {
                    min = r - l + 1;
                    str = s.Substring(l, r - l + 1);
                }
                char left = s[l];
                dic2[left]--;
                if (dic.ContainsKey(left) && dic2[left] < dic[left])
                {
                    count--;
                }
                l++;
            }
        }

        return str;
    }
}
