public class Solution {
    public int[] DailyTemperatures(int[] temp) {
       int[] res =  new int[temp.Length];
       Stack<int> st = new Stack<int>();
       st.Push(0);
       for(int i = 1;i< temp.Length;i++){
        if(temp[i] < temp[st.Peek()]){
            st.Push(i);
        }
        else{
            while( st.Count > 0 && temp[i] > temp[st.Peek()]){
                int index = st.Pop();
                res[index] = i - index;
            }
            st.Push(i);
        }
       } 

       return res;
    }
}