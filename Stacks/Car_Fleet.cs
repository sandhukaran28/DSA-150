public class Solution {
    public int CarFleet(int target, int[] position, int[] speed) {
        Array.Sort(position,speed);
        Stack<float> st= new Stack<float>();

        for(int i = position.Length -1 ;i >=0 ; i--){
            float time = ((float)target - position[i])/speed[i];
            if(st.Count == 0){
                st.Push(time);
            }
            else{
                if(time > st.Peek()){
                    st.Push(time);
                }
            }
        } 

        return st.Count;
    }
}
