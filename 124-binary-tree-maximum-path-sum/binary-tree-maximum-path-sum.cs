/**
 * Definition for a binary tree node.
 * public class TreeNode {
 *     public int val;
 *     public TreeNode left;
 *     public TreeNode right;
 *     public TreeNode(int val=0, TreeNode left=null, TreeNode right=null) {
 *         this.val = val;
 *         this.left = left;
 *         this.right = right;
 *     }
 * }
 */
public class Solution {
    int globalMax = int.MinValue;
    public int MaxPathSum(TreeNode root) {   
       DFS(root);
       return globalMax;
    }

     public int DFS(TreeNode root) {
       if (root == null) return 0;
       
       //only take positive node values 
       int left = Math.Max(0, DFS(root.left));
       int right = Math.Max(0, DFS(root.right));
       
        globalMax = Math.Max(globalMax , root.val + left + right);
        return  root.val + Math.Max(left , right);
     }
}