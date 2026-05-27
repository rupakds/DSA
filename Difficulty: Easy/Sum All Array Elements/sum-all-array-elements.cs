class Solution {
    public int arraySum(List<int> arr) {
        // code here
        int sum = 0;
        for(int i = 0; i < arr.Count; i++){
            
            sum = sum + arr[i];
            
        }
        
        return sum;
    }
}