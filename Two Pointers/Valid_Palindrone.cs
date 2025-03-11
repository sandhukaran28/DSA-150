public class Solution {
    public bool IsPalindrome(string s) {
        int i = 0;
        int j = s.Length -1;
        while(i < j){
            if(!(s[i] >= 'A' && s[i] <= 'Z') && !(s[i] >= 'a' && s[i] <= 'z') && !(s[i] >= '0' && s[i] <= '9')){
                i++;
                continue;
            }
            if(!(s[j] >= 'A' && s[j] <= 'Z') && !(s[j] >= 'a' && s[j] <= 'z') && !(s[j] >= '0' && s[j] <= '9')){
                j--;
                continue;
            }

            if(char.ToLower(s[i]) != char.ToLower(s[j])){
                return false;
            }
            else{
                i++;
                j--;
            }
        }

        return true;
    }
}