class Solution {
    public int lcm(int a, int b) {
        // code here
        int maxNumber = a > b ? a : b;
        int lcm = 1;
        
        for(int i = 2; i <= maxNumber; i++){
          
          while(a % i == 0 || b % i == 0){
              
              if(a % i == 0){
                  a = a / i;
              }
              
               if(b % i == 0){
                  b = b / i;
              }
              
              lcm = lcm * i;
              
          }    
            
        }
        return lcm;
    }
}