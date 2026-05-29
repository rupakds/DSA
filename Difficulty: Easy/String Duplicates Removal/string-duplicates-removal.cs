// User function template for Csharp
public class Solution {
    // Complete this function
    // Function to remove duplicates from the given string
    public string removeDuplicates(string s) {
        // Your code here
        
    HashSet<char> seen = new  HashSet<char>();    
    char[] ch = s.ToCharArray();
    StringBuilder result = new StringBuilder();
    
        foreach(char word in ch){
          
          if(!seen.Contains(word)){
              seen.Add(word);
              result.Append(word);
            }
        }
        return result.ToString();
    }
};