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

    // Function to return a list containing the postOrder traversal of the tree.
    public List<int> postOrder(Node root) {
        // code here
        List<int> result = new List<int>();
        Stack<Node> stack = new Stack<Node>();
        Node current = root;
        Node lastVisited = null;
        
        while(current != null || stack.Count > 0){
            if(current != null){
                stack.Push(current);
                current = current.left;
                
            }else{
                Node node = stack.Peek();
                
                if(node.right != null && lastVisited != node.right){
                    
                    current = node.right;
                    
                }else{
                    stack.Pop();
                    result.Add(node.data);
                    lastVisited = node;
                }
            }
        }
        return result;
        
    }
}