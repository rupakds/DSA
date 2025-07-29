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
    public List<int> inOrder(Node root) {
        // code here
        List<int> result = new List<int>();
        Node current = root;
        Stack<Node> stack = new Stack<Node>();
        
        while(current != null || stack.Count > 0){
            
            if(current != null){
                
                stack.Push(current);
                current = current.left;
            }else{
                current = stack.Pop();
                result.Add(current.data);
                
                current = current.right;
            }
        }
        return result;
        
    }
}