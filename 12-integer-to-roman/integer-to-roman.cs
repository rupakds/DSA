public class Solution {
    public string IntToRoman(int num) {
        
        Dictionary<int, string> rm = new Dictionary<int, string>
        {
            { 1, "I" }, { 5, "V" }, { 10, "X" }, { 50, "L" }, { 100, "C" }, { 500, "D" }, { 1000, "M" }
        };

        int digit = 0;
        int div = 1000;
        string romanStr = "";

        while (num > 0) {
            digit = num / div;  // Get the leading digit
            
            if (digit <= 3) {  
                romanStr += GetStrByNumber(rm[div], digit); // Example: 3 → "III"
            } else if (digit == 4) { 
                romanStr += rm[div] + rm[div * 5]; // Example: 4 → "IV"
            } else if (digit <= 8) { 
                romanStr += rm[div * 5] + GetStrByNumber(rm[div], digit - 5); // Example: 7 → "VII"
            } else if (digit == 9) { 
                romanStr += rm[div] + rm[div * 10]; // Example: 9 → "IX"
            }

            num %= div; // Remove processed digit
            div /= 10;  // Move to next lower place value
        }
        return romanStr;
    }

    public string GetStrByNumber(string str, int n) {
        string result = "";
        for (int i = 0; i < n; i++) {
            result += str;
        }
        return result;
    }
}
