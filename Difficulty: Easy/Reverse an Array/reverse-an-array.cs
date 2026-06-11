class Solution {
    public void reverseArray(int[] arr) {
        // code here    
        int[] reverse = new int[arr.Length];
        for(int i = 0; i < arr.Length; i++){
            
             reverse[i] = arr[arr.Length - i -1];
                
            }
         for(int i = 0; i < reverse.Length; i++){
        
            arr[i] = reverse[i];
            
        }
    }
}