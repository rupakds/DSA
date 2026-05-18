public class Solution {
    public bool IsPalindrome(int x) {
        
        int old = x;
        int reverse = 0;
               if(x < 0){
                return false;
            }

        while(x > 0){
          int digit = x % 10;
          if(reverse > int.MaxValue / 10 || reverse == int.MaxValue / 10 && digit > 7 ){
                return false;
             }

            if(reverse < int.MinValue / 10 || reverse == int.MinValue / 10 && digit < -8 ){
                return false;
             }

          reverse = reverse * 10 + digit;
          x = x / 10;
        }

        return reverse == old ? true : false;
    }
}