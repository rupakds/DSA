public class Solution {
    public int LongestConsecutive(int[] nums) {
        
        if(nums == null || nums.Length == 0) return 0;

        HashSet<int> set = new HashSet<int>(nums); //store all nums into hashset
        int longest = 0;

        foreach(int num in set){
            if(!set.Contains(num - 1)){
               int currentNum = num;
               int streak = 1;

               while(set.Contains(currentNum + 1)){ //check current number and sequence 
                 currentNum++;
                 streak++;
               }
               longest = Math.Max(longest, streak);
            }
        }
         
       return longest;
    }
}