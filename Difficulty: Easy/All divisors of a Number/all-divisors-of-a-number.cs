class Solution {
    public List<int> getDivisors(int n) {
        // code here
        List<int> divisor = new List<int>();
        
        for(int i = 1; i * i <= n; i++){
            
            if(n % i == 0){
                divisor.Add(i);
                
                if(i != n /i){
                    divisor.Add(n / i);
                }
            }
        }
        divisor.Sort();
        
        return divisor;
    }
}