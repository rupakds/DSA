using DriverCode;

class Solution {
    
    // Function to check if two trees are identical.
    public bool isIdentical(Node r1, Node r2) {
        // code here
        
        if(r1 == null && r2 == null) return true;
        if(r1 == null || r2 == null) return false;
        if(r1.data != r2.data) return false;
        
        return isIdentical(r1.left, r2.left) && isIdentical(r1.right, r2.right);
        
    }
}