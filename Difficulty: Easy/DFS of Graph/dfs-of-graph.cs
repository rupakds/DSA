class Solution {
    // Function to return a list containing the DFS traversal of the graph.
    public List<int> dfs(List<List<int>> adj) {
        // Code here
        var adjCount = adj.Count;
        var visited = new bool[adjCount];
        List<int> result = new List<int>();
        
        dfsUtil(0, adj, result, visited);
        
        return result;
    }
    
    public void dfsUtil(int node, List<List<int>> adj, List<int> result, bool[] visited){
        
        visited[node] = true;    
        result.Add(node);        
        
        foreach(int neighbor in adj[node]){
            
            if(!visited[neighbor]){
                
               dfsUtil(neighbor, adj, result, visited);
               
            }
        
        }        
    }
}