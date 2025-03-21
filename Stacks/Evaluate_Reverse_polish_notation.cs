public class Solution {
    public int EvalRPN(string[] arr) {
        Stack<int> st = new Stack<int>();
        for(int i = 0;i < arr.Length;i++){
            if(arr[i] == "*" || arr[i] == "+" || arr[i] == "-" || arr[i] == "/"){
                int n1 = st.Pop();
                int n2 = st.Pop();
                switch(arr[i]){
                    case "+":
                        st.Push(n1 + n2);
                        break;
                         case "-":
                        st.Push(n2 - n1);
                        break;
                         case "*":
                        st.Push(n1 * n2);
                        break;
                         case "/":
                        st.Push(n2 / n1);
                        break;
                }
            }
            else{
                st.Push(int.Parse(arr[i]));
            }
        }

        return st.Pop();
    }
}