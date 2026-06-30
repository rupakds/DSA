public class Solution {
    public string LargestOddNumber(string num) {

        for(int i = num.Length -1; i >= 0; i--){
          int digit  = num[i] - '0';
          
         if(digit % 2 == 1)
        return num.Substring(0, i + 1);
        }
        
        return "";

    }
}