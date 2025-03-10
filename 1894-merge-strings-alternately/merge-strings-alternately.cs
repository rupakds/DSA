public class Solution {
    public string MergeAlternately(string word1, string word2) {
       StringBuilder result = new StringBuilder();
       int i = 0 , j = 0;

      while(i < word1.Length || j < word2.Length){
        if(i < word1.Length) result.Append(word1[i++]);
        if(j < word2.Length) result.Append(word2[j++]);
      }

     return result.ToString();
    }
}