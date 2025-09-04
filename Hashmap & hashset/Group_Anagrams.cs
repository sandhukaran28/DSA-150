public class Solution
{
    public IList<IList<string>> GroupAnagrams(string[] strs)
    {
        IList<IList<string>> ans = new List<IList<string>>();
        Dictionary<string, List<string>> dic = new Dictionary<string, List<string>>();
        for (int i = 0; i < strs.Length; i++)
        {
            string s = strs[i];
            char[] chr = s.ToCharArray();
            Array.Sort(chr);
            string key = new string(chr);
            if (!dic.ContainsKey(key))
            {
                dic[key] = new List<string>();
            }

            dic[key].Add(s);
        }

        foreach (var kv in dic)
        {
            ans.Add(kv.Value);
        }

        return ans;
    }
}