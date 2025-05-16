public class Solution {
    public char FindTheDifference(string s, string t) {
        Dictionary<char,int> dic = new Dictionary<char,int>();
        for(int i=0;i< s.Length;i++){
            if(!dic.ContainsKey(s[i])){
                dic[s[i]] = 1;
            }
            else{
                dic[s[i]] = dic[s[i]] +1;
            }
        }

        for(int i = 0;i< t.Length;i++){
            if(dic.ContainsKey(t[i])){
                dic[t[i]] = dic[t[i]] - 1;
                if(dic[t[i]] < 0){
                    return t[i];
                } 
            }
            else{
                return t[i];
            }
        }
        return ' ';
    }
}