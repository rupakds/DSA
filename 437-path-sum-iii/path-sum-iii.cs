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
    int result = 0;
    public int PathSum(TreeNode root, int targetSum) {
       if(root == null) return 0;
       long currentSum = 0;
          DFSPreOrder(root, targetSum, currentSum);

          PathSum(root.left, targetSum);
      PathSum(root.right, targetSum);
      return result;

    }
    public void DFSPreOrder(TreeNode root, int targetSum, long currentSum){
      if(root == null) return;
      
      currentSum += root.val;
      if(currentSum == targetSum){
        result++;
      }

      DFSPreOrder(root.left, targetSum, currentSum);
      DFSPreOrder(root.right, targetSum, currentSum);
      
    } 
}