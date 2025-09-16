public class Solution {
    public bool CheckInclusion(string s1, string s2) {
        if(s1.Length > s2.Length) return false;
        int[] s1Window = new int[26];
        int[] s2Window = new int[26];

        //storing s1 s1 window size into both array  
        for(int i =0; i < s1.Length; i++){
          s1Window[s1[i] - 'a']++;
          s2Window[s2[i] - 'a']++;
        }

        int windowSize = s2.Length - s1.Length;

        for(int i = 0; i < windowSize; i++){
          //check for permutation in string 
          if(IsMatch(s1Window, s2Window)) return true;
        
          s2Window[s2[i] - 'a']--;  //remove first char from window
          s2Window[s2[i + s1.Length] - 'a']++;
        }
        return IsMatch(s1Window, s2Window);

    }
    public bool IsMatch(int[] arr1, int[] arr2){
        for(int i =0;i <26; i++){
          if(arr1[i] != arr2[i]) return false;
        }
       return true;
    }
}