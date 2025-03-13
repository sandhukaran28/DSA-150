public class Solution
{
    public bool IsValid(string s)
    {
        Stack<char> st = new Stack<char>();

        for (int i = 0; i < s.Length; i++)
        {
            if (s[i] == '(' || s[i] == '[' || s[i] == '{')
            {
                st.Push(s[i]);
            }
            else
            {
                if (st.Count == 0)
                {
                    return false;
                }

                char last = st.Pop();

                if ((s[i] == ')' && last == '(') || (s[i] == '}' && last == '{') || (s[i] == ']' && last == '['))
                {
                    continue;
                }
                else
                {
                    return false;
                }
            }
        }
        return st.Count() != 0 ? false : true;
    }
}