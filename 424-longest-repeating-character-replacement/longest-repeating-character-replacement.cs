public class Solution {
    public int CharacterReplacement(string s, int k) {
        
        Dictionary<char, int> dict = new Dictionary<char, int>();
        int left = 0;
        int maxFreq = 0;
        int maxLength =0;

        for(int right =0; right < s.Length; right++){
          char c = s[right];

          if(!dict.ContainsKey(c)){
               dict[c] = 0;
          }
             dict[c]++;
          
          maxFreq = Math.Max(maxFreq, dict[c]);
           
           int windowSize = right - left +1;

           if(windowSize - maxFreq > k ){
             dict[s[left]]--;
             left++;
           }

           maxLength = Math.Max(maxLength, right - left +1);


        }
        return maxLength;
    }
}