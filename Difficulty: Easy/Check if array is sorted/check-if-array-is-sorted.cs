class Solution {

    public bool isSorted(int[] arr) {
        // Code here
             for(int i = 0; i < arr.Length - 1; i++){ 
            
            if(arr[i] > arr[i+1]){
                
                return false;
            }
        }
       return true;
    }
}