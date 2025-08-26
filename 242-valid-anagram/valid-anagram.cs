public class Solution {
    public bool IsAnagram(string s, string t) {
       
       Dictionary<char, int> dict = new Dictionary<char, int>();

        foreach(char c in s){

            if(dict.ContainsKey(c)){

                dict[c]++;  //increment if exist 

            }else{
                dict[c] = 1; // add new character 
            }
        }

        foreach(char ch in t){

            if(dict.ContainsKey(ch)){

            dict[ch]--;  //decreament if exist 

            if(dict[ch] == 0){

                dict.Remove(ch); // remove if char value is 0
            }
        }else{
            return false;
        }
        
        }

          return dict.Count == 0;

    }
}