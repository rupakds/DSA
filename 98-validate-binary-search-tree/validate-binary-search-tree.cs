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
    public bool IsValidBST(TreeNode root) {
         
         return ValidateBST(root, long.MinValue, long.MaxValue);
    }
    public bool ValidateBST(TreeNode node, long minValue , long maxValue){
  
        if(node == null) return true; 
       
            if(node.val <= minValue || node.val >= maxValue){
                return false;
            }

        return ValidateBST(node.left, minValue, node.val) && ValidateBST(node.right, node.val, maxValue);

    }
}