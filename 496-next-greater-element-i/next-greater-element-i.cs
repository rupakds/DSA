public class Solution {
    public int[] NextGreaterElement(int[] nums1, int[] nums2) {
           
           Dictionary<int, int> nextGreaterMap = new Dictionary<int, int>();
           Stack<int> stack = new Stack<int>();

           foreach(int num in nums2){
            while(stack.Count > 0 && num > stack.Peek()){
                int prev = stack.Pop();
                nextGreaterMap[prev] = num;
            }
            stack.Push(num); //after the while loop, push num into the stack
           }

           //update all non greater elemt as -1 
           while(stack.Count > 0){
            nextGreaterMap[stack.Pop()] = -1;
           }

           //now match with nums1 and build result
           int[] result = new int[nums1.Length];
           for(int i = 0; i < nums1.Length; i++){
              result[i] = nextGreaterMap[nums1[i]];
           }

           return result;
           
    }
}