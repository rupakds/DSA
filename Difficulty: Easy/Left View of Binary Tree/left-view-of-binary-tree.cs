class Solution
{
    // Function to return a list containing elements of left view of the binary tree.
    public List<int> LeftView(Node root)
    {
        var result = new List<int>();
        if (root == null) return result;

        var queue = new Queue<Node>();
        queue.Enqueue(root); // FIXED

        while (queue.Count > 0)
        {
            int levelSize = queue.Count;

            for (int i = 0; i < levelSize; i++)
            {
                var node = queue.Dequeue();

                // First node of the level
                if (i == 0)
                    result.Add(node.data); // FIXED: add node.data, not node

                // Always enqueue children, not just for the first node
                if (node.left != null) queue.Enqueue(node.left);
                if (node.right != null) queue.Enqueue(node.right);
            }
        }

        return result;
    }
}
