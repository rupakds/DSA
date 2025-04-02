public class Solution {
    public bool IsAnagram(string s, string t) {
        Dictionary<char, int> dict = new Dictionary<char, int>();

        foreach(char ch in s){
            if(dict.ContainsKey(ch)){
                dict[ch]++;
            }else{
                dict[ch] = 1;
            }
        }

        foreach(char ch in t){
            if(!dict.ContainsKey(ch)){
                return false; //having extra character 
            }else{
                dict[ch]--;
            }

            if(dict[ch] == 0){
                dict.Remove(ch); // Remove if count is zero
            }
        }
   return dict.Count == 0;
    }
}