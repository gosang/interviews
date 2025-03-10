// Course Schedule
// Problem: Determine if you can finish all courses given prerequisites (no cycles).

// Divide-and-Conquer Solution
// Explanation: Split the graph and check for cycles in each half and across. Inefficient due to graph traversal.
// Time Complexity: O(V + E log V), Space Complexity: O(V)


public class DivideConqueryCourseSchedule {
    public bool CanFinishDivideConquer(int numCourses, int[][] prerequisites) {
        var graph = BuildGraph(numCourses, prerequisites);
        return CanFinishHelper(graph, new HashSet<int>(), 0, numCourses - 1);
    }
    
    private bool CanFinishHelper(List<List<int>> graph, HashSet<int> visited, int left, int right) {
        if (left > right) return true;
        int mid = left + (right - left) / 2;
        return CanFinishHelper(graph, visited, left, mid) && 
               CanFinishHelper(graph, visited, mid + 1, right) && 
               !HasCycle(graph, new HashSet<int>(), new HashSet<int>(), left, right);
    }
    
    private bool HasCycle(List<List<int>> graph, HashSet<int> visited, HashSet<int> recStack, int left, int right) {
        for (int i = left; i <= right; i++) {
            if (!visited.Contains(i) && Dfs(graph, i, visited, recStack)) return true;
        }
        return false;
    }
    
    private bool Dfs(List<List<int>> graph, int node, HashSet<int> visited, HashSet<int> recStack) {
        if (recStack.Contains(node)) return true;
        if (visited.Contains(node)) return false;
        visited.Add(node);
        recStack.Add(node);
        foreach (int neighbor in graph[node]) {
            if (Dfs(graph, neighbor, visited, recStack)) return true;
        }
        recStack.Remove(node);
        return false;
    }
    
    private List<List<int>> BuildGraph(int n, int[][] edges) {
        var graph = new List<List<int>>(n);
        for (int i = 0; i < n; i++) graph.Add(new List<int>());
        foreach (var edge in edges) graph[edge[1]].Add(edge[0]);
        return graph;
    }
}


// Optimal Solution
// Explanation: Use DFS with cycle detection.
// Time Complexity: O(V + E), Space Complexity: O(V)

public class OptimalCourseSchedule {
    public bool CanFinish(int numCourses, int[][] prerequisites) {
        var graph = new List<List<int>>(numCourses);
        for (int i = 0; i < numCourses; i++) graph.Add(new List<int>());
        foreach (var prereq in prerequisites) graph[prereq[1]].Add(prereq[0]);
        
        HashSet<int> visited = new HashSet<int>();
        HashSet<int> recStack = new HashSet<int>();
        
        for (int i = 0; i < numCourses; i++) {
            if (!Dfs(i, graph, visited, recStack)) return false;
        }
        return true;
    }
    
    private bool Dfs(int node, List<List<int>> graph, HashSet<int> visited, HashSet<int> recStack) {
        if (recStack.Contains(node)) return false;
        if (visited.Contains(node)) return true;
        visited.Add(node);
        recStack.Add(node);
        foreach (int neighbor in graph[node]) {
            if (!Dfs(neighbor, graph, visited, recStack)) return false;
        }
        recStack.Remove(node);
        return true;
    }
}