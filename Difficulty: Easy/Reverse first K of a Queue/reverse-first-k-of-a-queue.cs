//{ Driver Code Starts

using System;
using System.Collections.Generic;

class Program {
    static void Main() {
        int t = int.Parse(Console.ReadLine().Trim()); // Read number of test cases
        while (t-- > 0) {
            string inputLine = Console.ReadLine().Trim(); // Read queue elements
            string[] inputArray =
                inputLine.Split(' '); // Split input by space to get queue elements

            Queue<int> q = new Queue<int>();

            // Enqueue each number from input to the queue
            foreach (var number in inputArray) {
                q.Enqueue(int.Parse(number));
            }

            int k =
                int.Parse(Console.ReadLine().Trim()); // Read the number k for reverse

            Solution solution = new Solution();
            Queue<int> result = solution.reverseFirstK(
                q, k); // Call method to reverse the first k elements

            // Output the result queue
            Console.WriteLine(
                string.Join(" ", result)); // Print the result queue elements
            Console.WriteLine("~");        // As per your original code's output format
        }
    }
}

// } Driver Code Ends


class Solution {
    public Queue<int> reverseFirstK(Queue<int> q, int k) {
        if(q.Count >= k){  //check the queue count 
        // code here 
        Stack<int> stack = new Stack<int>();
        int restQueueSize = q.Count - k;
        
        for(int i = 0; i < k; i++){
            
            stack.Push(q.Dequeue()); //pushing into stack
        }
        
        while(stack.Count > 0){
            q.Enqueue(stack.Pop());
        }
        
        for(int i = 0; i < restQueueSize; i++){
            
            int value = q.Dequeue(); //pop from stack
            q.Enqueue(value); //pushing into queue
        }
        
        }
        return q;
    }
}