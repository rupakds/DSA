public class Solution {
    public int[] TwoSum(int[] nums, int target) {
    
      Dictionary<int, int> dict = new Dictionary<int, int>();

      int i = 0;
      while(i < nums.Length){

        int complement = target - nums[i];
        
        if(dict.ContainsKey(complement)){
            return new int[]{dict[complement], i};
        }

        dict[nums[i]] = i;
        i++;
      }
       
       return new int[0];
    }

}
