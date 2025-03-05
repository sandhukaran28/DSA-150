public class Solution {
    public bool IsAnagram(string s, string t) {
        if(s.Length != t.Length){
            return false;
        }
        Dictionary<char, int> ht = new Dictionary<char, int>();
        foreach(char c in s){
            if(ht.ContainsKey(c)){
                ht[c]++;
            }
            else{
               ht[c] = 1 ;
            }
        }

        foreach(char c in t){
            if(ht.ContainsKey(c)){
                ht[c]--;
                if(ht[c] == 0){
                    ht.Remove(c);
                }
            }
            else{
                return false;
            }
        }

        return true;
    }
}