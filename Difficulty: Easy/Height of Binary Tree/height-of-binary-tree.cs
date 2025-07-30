/*
class Node
{
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
    public int height(Node node) {
        // code here

        if(node ==  null){
            return 0;
        }
                
        Queue<Node> queue = new Queue<Node>();
        
        queue.Enqueue(node);
        int depth = -1;
        
        while(queue.Count > 0){
            
            int levelCount = queue.Count;
      
            
              for(int i = 0 ; i < levelCount; i++){
                  
                    Node current = queue.Dequeue();
                    
                    if(current.left != null){
                        queue.Enqueue(current.left);
                    }
                     if(current.right != null){
                        queue.Enqueue(current.right);
                    }
              }
              depth++;
        }
        return depth;
    }
}