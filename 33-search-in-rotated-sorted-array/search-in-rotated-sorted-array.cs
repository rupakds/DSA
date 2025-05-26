public class Solution {
    public int Search(int[] nums, int target) {
        
        int start = 0;
        int end = nums.Length - 1;

        while(start <= end){
            int mid = start + (end - start) / 2;

            if(nums[mid] == target){
                return mid;
            }

            if(nums[start] <= nums[mid]){ //Check if the left half is sorted

                    if (nums[start] <= target && target < nums[mid]) { //if target lies in left
                        end = mid - 1;
                    }else{
                        start = mid + 1;
                    }
                }else{  //the right must be sorted in else 
                    //the target lies within right 
                    if(nums[mid] < target && target <= nums[end]) {
                        start = mid + 1;
                    }else{
                        end = mid - 1;
                    }
            }
        }

        return -1; // target not found
    }
}