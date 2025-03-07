public class Solution {
    public IList<IList<string>> GroupAnagrams(string[] strs) {
        Dictionary<string,List<string>> dic = new Dictionary<string,List<string>>();
        for(int i = 0;i< strs.Length;i++){
            //sorting string
            char[] chars = strs[i].ToArray();
            Array.Sort(chars);
            string sortedString = new String(chars);

            //Adding to hashmap
            if(dic.ContainsKey(sortedString)){
                List<string> ls = dic[sortedString];
                ls.Add(strs[i]);

            } 
            else{
                List<string> ls = new List<string>();
                ls.Add(strs[i]);
                dic.Add(sortedString, ls);
            }
        }
        IList<IList<string>> ans = new List<IList<string>>();
        foreach(var key in dic){
            ans.Add(key.Value);
        }

        return ans;

    }


}