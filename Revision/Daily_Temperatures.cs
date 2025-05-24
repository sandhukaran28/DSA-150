public class Solution
{
    public int[] DailyTemperatures(int[] temp)
    {
        int[] ans = new int[temp.Length];
        Stack<int> st = new Stack<int>();
        for (int i = 0; i < temp.Length; i++)
        {
            while (st.Count > 0 && temp[i] > temp[st.Peek()])
            {
                int index = st.Pop();
                ans[index] = i - index;
            }
            st.Push(i);

        }

        return ans;
    }
}