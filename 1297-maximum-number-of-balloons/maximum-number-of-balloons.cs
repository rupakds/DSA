public class Solution {
    public int MaxNumberOfBalloons(string text) {
        Dictionary<char, int> dict = new Dictionary<char, int>() {
            { 'b', 1 },
            { 'a', 1 },
            { 'l', 2 },
            { 'o', 2 },
            { 'n', 1 }
        };
         Dictionary<char, int> freq = new Dictionary<char, int>();

         foreach(char c in text){
            if(dict.ContainsKey(c)){
                if(freq.ContainsKey(c)){
                   freq[c]++;
                }else{
                   freq[c] = 1;
                }
            }
         }
         int result = int.MaxValue;
         foreach(var kv in dict){
            char ch = kv.Key;
            int value = kv.Value;

            if(!freq.ContainsKey(ch)) return 0;
            result = Math.Min(result, freq[ch] / value);
         }
      return result;
    }
}