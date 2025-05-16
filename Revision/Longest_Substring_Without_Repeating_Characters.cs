public class Solution {
    public int LengthOfLongestSubstring(string s) {
        Dictionary<char,int> dic = new Dictionary<char, int>();
        int max = 0,l = 0;
        for(int i = 0;i < s.Length;i++){
            if(dic.ContainsKey(s[i]) && dic[s[i]] >= l ){
                    l = dic[s[i]]+1;
            }

            dic[s[i]] = i;
            max = Math.Max(max, i - l +1);
        }
        
        return max;
    }
}