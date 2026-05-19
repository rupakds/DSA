public class Solution {
    public bool CheckPerfectNumber(int num) {
        
        int perfectNum = 0;
        for(int i =1; i < num; i++){
          if(num % i == 0 ){
            perfectNum = perfectNum + i;
          }
        }
       return perfectNum == num ? true : false;
    }
}