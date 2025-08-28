public class Solution {
    public int[] TopKFrequent(int[] nums, int k) {
        Dictionary<int, int> dict = new Dictionary<int, int>();

        int i = 0;
        while(i < nums.Length){
          if(dict.ContainsKey(nums[i])){
              dict[nums[i]]++;
          }else{
            dict[nums[i]] = 1;
          }
          i++;
        }

        var top2Keys = dict
            .OrderByDescending(x => x.Value)
            .Take(k)
            .Select(x => x.Key)
            .ToArray();   // directly array

      return top2Keys;
    }
}