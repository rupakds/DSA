/*
class Node {
    public int data;
    public Node left;
    public Node right;

    public Node(int key) {
        this.data = key;
        this.left = null;
        this.right = null;
    }
}
*/
class Solution {
    public List<List<int>> levelOrder(Node root) {
        // Your code here
        List<List<int>> result = new List<List<int>>();
        Queue<Node> queue = new Queue<Node>();
        queue.Enqueue(root);
        
        while(queue.Count > 0){
            
            List<int> subTree = new List<int>(); 
            int levelCount = queue.Count;
            Node current = null;
            
            for(int i = 0; i < levelCount; i++){
                
                current = queue.Dequeue();
                subTree.Add(current.data);
                
                if(current.left != null){
                    queue.Enqueue(current.left);
                }
                
                if(current.right != null){
                    queue.Enqueue(current.right);
                }
            }
            
            result.Add(subTree);
            
         }
        
        return result;
 
    }
}