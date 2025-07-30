/*
class Node
    {
        public int data;
        public Node left;
        public Node right;

        public Node(int key)
        {
            this.data = key;
            this.left = null;
            this.right = null;
        }
    }
*/
class Solution {
    // Function to return a list containing the preorder traversal of the tree.
    public List<int> preorder(Node root) {
        // code here
     List<int> result = new List<int>();
     
     if(root == null) {
         return result;
     }
     
     Stack<Node> stack = new Stack<Node>();
     Node current = root;
     
     stack.Push(current);
     
         while(stack.Count > 0){
             
             current = stack.Pop();
             result.Add(current.data);
             
             if(current.right != null){
                 stack.Push(current.right);
             }
             
               if(current.left != null){
                 stack.Push(current.left);
             }
         }
     
        return result;
        
    }
}