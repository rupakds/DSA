using DriverCode;

/*
public class Node{
    public int data;
    public Node left;
    public Node right;

    public Node(int x){
        data = x;
        left = right = null;
    }
}
*/
class Solution {
    
    private int maxDiameter = 0;
     public int diameter(Node root) {
         height(root);
         return maxDiameter;
     }
    public int height(Node root) {
        // Your code here
        if(root == null){
            return 0;
        }
        
        int left = height(root.left);
        int right = height(root.right);
        
         maxDiameter = Math.Max(maxDiameter , left + right);
        return 1 + Math.Max(left, right);
    }
}