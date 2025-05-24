public class Solution
{
    public int EvalRPN(string[] tokens)
    {
        Stack<int> st = new Stack<int>();

        for (int i = 0; i < tokens.Length; i++)
        {
            if (tokens[i].Length == 1 && (tokens[i] == "+" || tokens[i] == "-" || tokens[i] == "*" || tokens[i] == "/"))
            {
                int n1 = st.Pop();
                int n2 = st.Pop();
                switch (tokens[i])
                {
                    case "+":
                        {
                            st.Push(n2 + n1);
                            break;
                        }
                    case "-":
                        {
                            st.Push(n2 - n1);
                            break;
                        }
                    case "*":
                        {
                            st.Push(n2 * n1);
                            break;
                        }
                    case "/":
                        {
                            st.Push(n2 / n1);
                            break;
                        }
                }
            }
            else
            {
                st.Push(int.Parse(tokens[i]));
            }
        }

        return st.Pop();
    }
}