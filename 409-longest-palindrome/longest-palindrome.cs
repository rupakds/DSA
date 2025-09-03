public class Solution {
    public int LongestPalindrome(string s) {
      Dictionary<char, int> dict = new Dictionary<char, int>();
      
      foreach(char c in s){
         if(dict.ContainsKey(c)){
             dict[c]++;
         }else{
            dict[c] = 1;
         }
      }
      int result = 0;
      bool hasOdd = false;

      foreach(var freq in dict.Values){
        if((freq % 2) == 0){
            result += freq;
        }else{
           result += freq - 1;
           hasOdd = true;
        } 
      }
      if(hasOdd) result++;
     return result;  
    }
}