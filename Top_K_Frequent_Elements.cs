public class Solution {
    public int[] TopKFrequent(int[] nums, int k) {
        Dictionary<int,int> dic = new Dictionary<int,int>();
        for(int i=0;i<nums.Length;i++){
            if(dic.ContainsKey(nums[i])){
                dic[nums[i]] = ++dic[nums[i]];
            }
            else{
                dic[nums[i]] = 1;
            }
        }

        List<int> ls = dic.OrderByDescending(pair => pair.Value).Select(pair => pair.Key).Take(k).ToList();

        return ls.ToArray();
    }
}