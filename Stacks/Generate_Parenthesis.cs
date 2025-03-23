public class Solution {
    IList<string> ls = new List<string>();
    public IList<string> GenerateParenthesis(int n) {
    generate("(",1,0,n);
    return ls;
    }

    public void generate(string st, int open,int close, int n){
        if(open + close == 2*n){
             ls.Add(st);
             return;
        }
        if(open < n){
           generate(st+'(', open+1, close, n);
        }
        if(open == n || close < open){
             generate(st+')', open, close+1, n);
        }

    }
}