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
    public int WidthOfBinaryTree(TreeNode root) {
       if(root == null) return 0;
       Queue<(TreeNode node, long index)> queue = new Queue<(TreeNode, long)>();
       queue.Enqueue((root, 1));
       int maxWidth = 0;

       while(queue.Count > 0){
         int levelCount = queue.Count;
         long left = queue.Peek().index;
         long right = left;

        
        for(int i = 0; i < levelCount; i++){
          var (node, idx) = queue.Dequeue();
          right = idx;

         if(node.left != null){
            queue.Enqueue((node.left, 2 * idx));
         }
  
         if(node.right != null){
             queue.Enqueue((node.right, 2 * idx + 1));
         }
          
        }
         maxWidth = Math.Max(maxWidth, (int)(right - left + 1));
       }
       return maxWidth;
    }
}