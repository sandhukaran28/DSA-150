public class Solution
{
    public int EvalRPN(string[] tokens)
    {
        Stack<int> st = new Stack<int>();
        for (int i = 0; i < tokens.Length; i++)
        {
            string curr = tokens[i];
            if (curr.Length == 1 &&
            (curr == "+" || curr == "-" || curr == "/" || curr == "*"))
            {
                int n2 = st.Pop();
                int n1 = st.Pop();
                switch (curr)
                {
                    case "+":
                        {
                            st.Push(n1 + n2);
                            break;
                        }
                    case "-":
                        {
                            st.Push(n1 - n2);
                            break;
                        }
                    case "*":
                        {
                            st.Push(n1 * n2);
                            break;

                        }
                    case "/":
                        {
                            st.Push(n1 / n2);
                            break;
                        }
                }
            }
            else
            {
                st.Push(int.Parse(curr));
            }
        }

        return st.Pop();
    }
}