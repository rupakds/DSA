using System;
using System.Collections.Generic;

public class Solution {
    public int LengthOfLongestSubstring(string s) {
        Dictionary<char, int> dict = new Dictionary<char, int>();
     int left =0; int maxLength =0;

     for(int i = 0; i < s.Length; i++){
       char c = s[i];

       if(dict.ContainsKey(s[i]) && dict[c] >= left){
         left = dict[c] + 1;
       }

       dict[c] = i;

       maxLength = Math.Max(maxLength, i - left +1);

     }
     return maxLength;

    }
}
