public class Solution {
    public void SortColors(int[] nums) {
        int i = 0, j =0;
        int n = nums.Length;

        for(i =0; i < n-1; i++){
            for(j =0; j < n-i-1; j++){
                if(nums[j] > nums[j + 1]){
                   int temp = nums[j];
                   nums[j] = nums[j + 1];
                   nums[j + 1] = temp;
                }
                  
            }
        }
    }
}