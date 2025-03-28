public class Solution {
    public int RomanToInt(string s) {
            Dictionary<char, int> dict = new Dictionary<char, int>();
                dict.Add('I', 1);
                dict.Add('V', 5);
                dict.Add('X', 10);
                dict.Add('L', 50);
                dict.Add('C', 100);
                dict.Add('D', 500);
                dict.Add('M', 1000);
            int n = s.Length;
            int sumTotal = 0;

          for(int left = 0; left < n; left++){
                if( left < n - 1  &&   dict[s[left]] < dict[s[left + 1]]){
                sumTotal -= dict[s[left]]; 
                }else{
                    sumTotal += dict[s[left]];
                }
          }
    return sumTotal;

    }
}