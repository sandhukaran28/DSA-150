public class Solution
{
    public IList<IList<string>> GroupAnagrams(string[] strs)
    {
        Dictionary<string, IList<string>> dic = new Dictionary<string, IList<string>>();

        for (int i = 0; i < strs.Length; i++)
        {
            char[] arr = strs[i].ToCharArray();
            Array.Sort(arr);
            string key = new String(arr);
            if (!dic.ContainsKey(key))
            {
                IList<string> ls = new List<string>();
                ls.Add(strs[i]);
                dic[key] = ls;
            }
            else
            {
                IList<string> ls = dic[key];
                ls.Add(strs[i]);
            }
        }

        IList<IList<string>> ans = new List<IList<string>>();
        foreach (var ele in dic)
        {
            ans.Add(ele.Value);
        }

        return ans;
    }
}