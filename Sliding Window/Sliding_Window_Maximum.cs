public class Solution {
    public int[] MaxSlidingWindow(int[] nums, int k) {
        //queue

        //loop l to r

        //pop until small then push

        //if more than window, pop from front and then add first to ans

        LinkedList<int> ll = new LinkedList<int>();
        List<int> ans = new List<int>();

        int l =0;
        for(int r = 0;r < nums.Length;r++){
            int curr = nums[r];

            while(ll.Count > 0 && (nums[ll.Last.Value] < curr)){
                ll.RemoveLast();
            }
            ll.AddLast(r);

            if(r >= k-1){
                while(ll.Count > 0 &&  ll.First.Value < l ){
                    ll.RemoveFirst();
                }
                ans.Add(nums[ll.First.Value]);
                l++;

            }
        }

        return ans.ToArray();
    }
}