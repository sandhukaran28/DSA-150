public class Solution {
    public int MinEatingSpeed(int[] piles, int h) {
        int max = -1;
        for(int i = 0;i< piles.Length;i++){
            if(piles[i] > max){
                max = piles[i];
            }
        }
        int ans = max;
        int l = 1, r = max;
            while(l <= r){
                int mid = (l+r)/2;
                int count = 0;
                for(int j = 0;j< piles.Length;j++){
                    count += (int)Math.Ceiling((double)piles[j] / mid);
                }
                if(count > h){
                    l = mid+1;
                }
                else{
                    r = mid -1;
                    ans = mid;
                }
            }
            return ans;
    }
}
