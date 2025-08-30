public class Solution
{
    public string MinRemoveToMakeValid(string s)
    {
        Stack<int> st = new Stack<int>();
        HashSet<int> hs = new HashSet<int>();

        for (int i = 0; i < s.Length; i++)
        {
            if (s[i] == '(')
            {
                st.Push(i);
            }
            else if (s[i] == ')')
            {
                if (st.Count == 0)
                {
                    hs.Add(i);
                }
                else
                {
                    st.Pop();
                }
            }
        }

        while (st.Count != 0)
        {
            hs.Add(st.Pop());
        }

        string ans = "";
        for (int i = 0; i < s.Length; i++)
        {
            if (!hs.Contains(i))
            {
                ans += s[i];
            }
        }

        return ans;
    }
}



public class Solution {
    public string MinRemoveToMakeValid(string s) {
        int open = 0;
        var ans = new StringBuilder();
        for(int i=0;i < s.Length;i++){
            if(s[i] == '('){
                open++;
                
            }
            else if(s[i] == ')'){
                if(open > 0){
                    open--;
                  
                }
                else{
                    continue;
                }
            }
                ans.Append(s[i]);
        }
        var res = new StringBuilder(ans.Length);
        int close = 0;
        for(int i = ans.Length -1;i>=0 ;i--){
            if(ans[i] == ')'){
                close++;
            }
            else if(ans[i] == '('){
                if(close > 0){
                    close--;
                }
                else{
                    continue;
                }
            }

            res.Append(ans[i]);
        }

        char[] arr = res.ToString().ToCharArray();
            Array.Reverse(arr);
        return new string(arr);
    }
}