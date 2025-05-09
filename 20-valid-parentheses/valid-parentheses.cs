public class Solution {
    public bool IsValid(string s) {
        
        //storing the brackets inot dictionary
      var dict = new Dictionary<char, char> {
            { '(', ')' },
            { '{', '}' },
            { '[', ']' }
        };
     
     var stack = new Stack<char>();
     
     foreach(char ch in s){
       if(dict.ContainsKey(ch)){ //checking ch is aviable or ot in dictionary
          stack.Push(dict[ch]); //pushing The value in the dictionary corresponding to the key 
       }
     else{
        if(stack.Count == 0 || stack.Pop() != ch){  // check stack top element is matching with ch or not 
            return false;
        }

      }
    }

     return stack.Count == 0; //if stack is zero then return false otherwise true

    }
}