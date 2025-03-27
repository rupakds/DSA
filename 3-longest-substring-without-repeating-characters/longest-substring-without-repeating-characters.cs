using System;
using System.Collections.Generic;

public class Solution {
    public int LengthOfLongestSubstring(string s) {
        Dictionary<char, int> dict = new Dictionary<char, int>();
        int left = 0, maxLength = 0;

        for (int right = 0; right < s.Length; right++) {
            char currentChar = s[right];

            if (dict.ContainsKey(currentChar) && dict[currentChar] >= left) {
                left = dict[currentChar] + 1; // Move left pointer to avoid duplicate
            }

            dict[currentChar] = right; // Store character's latest index
            
            // Replace Math.Max with manual comparison
            int currentLength = right - left + 1;
            if (currentLength > maxLength) {
                maxLength = currentLength;
            }
        }

        return maxLength;
    }
}
