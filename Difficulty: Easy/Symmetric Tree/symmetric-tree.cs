class Solution {
    public bool isSymmetric(Node root) {
        // Code here
        if(root == null) return true;
        
        return IsMirror(root.left, root.right);
    }
    
    public bool IsMirror(Node left, Node right){
        
        if(left == null && right == null) return true;
        if(left == null || right == null) return false;
        if(left.data != right.data) return false;
        
        return IsMirror(left.left, right.right) && IsMirror(left.right, right.left);
        
    }
}