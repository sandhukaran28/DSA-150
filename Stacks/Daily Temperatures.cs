public class Solution {
    public int[] DailyTemperatures(int[] arr) {
        int[] ans = new int[arr.Length];
        Stack<int> st=  new Stack<int>();

        for(int i=0;i< arr.Length;i++){
            int curr = arr[i];
            while(st.Count > 0 && arr[st.Peek()] < curr){
                int day = st.Pop();
                ans[day] = i - day; 
            }

            st.Push(i);
        }

        return ans;
    }
}