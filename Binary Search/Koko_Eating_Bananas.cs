public class Solution {
    public int MinEatingSpeed(int[] piles, int h) {
        int max = -1;
        for(int i = 0;i< piles.Length ;i++){
            if(piles[i] > max){
                max = piles[i];
            }
        }

        int l = 1, r = max , sol = r;
        while(l <= r){
            int mid = (l+r)/2;
            int hours  = 0;
             for(int i = 0;i< piles.Length ;i++){
                hours+= (int)Math.Ceiling((double)piles[i] / mid);
             }

             if(hours <= h){
                sol = mid;
                r = mid -1;
             }
             else{
                l = mid+1;
             }
        }

        return sol;
    }
}
