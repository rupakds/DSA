public class Solution {
    public IList<int> InorderTraversal(TreeNode root) {
        List<int> result = new List<int>();
        InOrder(root, result);
        return result;
    }

    private void InOrder(TreeNode node, List<int> result) {
        if (node == null) return;

        InOrder(node.left, result);        // Visit left
        result.Add(node.val);              // Visit node
        InOrder(node.right, result);       // Visit right
    }
}
