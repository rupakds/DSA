public class Solution {
    public void Rotate(int[] nums, int k) {
        int n = nums.Length;
        k = (k%n);
        int[] rotate = new int[n];

        for(int i =0; i < n; i++){
            rotate[(i + k) % n] = nums[i];
        }

        for(int i =0; i < n; i++){
              nums[i] = rotate[i];
        }
    }
}