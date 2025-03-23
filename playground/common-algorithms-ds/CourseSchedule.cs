// Course Schedule
// Problem: Given numCourses and prerequisites [ai, bi] (ai depends on bi), determine if you can finish all courses (no cycles).

// Brute Force Solution
// The brute force approach generates all possible orderings of courses (permutations) and checks if each satisfies the prerequisites. We build an adjacency list representation of the graph, then use backtracking to try every permutation, ensuring that for each course added, all its prerequisites are already in the order. If any valid order exists, there’s no cycle. This is extremely inefficient due to the factorial number of permutations.
// Time Complexity: O(n!) - Generating and checking all permutations of n courses.
// Space Complexity: O(n) - Store the graph and current order.

public class BruteForceCoursesSchedule {
     public bool CanFinishBruteForce(int numCourses, int[][] prerequisites) {
        var graph = new List<List<int>>(numCourses);
        for (int i = 0; i < numCourses; i++) graph.Add(new List<int>());
        foreach (var prereq in prerequisites) graph[prereq[1]].Add(prereq[0]);
        
        List<int> order = new List<int>();
        HashSet<int> visited = new HashSet<int>();
        return GenerateOrders(graph, numCourses, order, visited);
    }
    
    private bool GenerateOrders(List<List<int>> graph, int n, List<int> order, HashSet<int> visited) {
        if (order.Count == n) return true;
        
        for (int i = 0; i < n; i++) {
            if (!visited.Contains(i)) {
                bool canAdd = true;
                foreach (int pre in graph[i]) {
                    if (!order.Contains(pre)) {
                        canAdd = false;
                        break;
                    }
                }
                if (canAdd) {
                    visited.Add(i);
                    order.Add(i);
                    if (GenerateOrders(graph, n, order, visited)) return true;
                    order.RemoveAt(order.Count - 1);
                    visited.Remove(i);
                }
            }
        }
        return false;
    }
}



// Divide-and-Conquer Solution
// Split the graph and check for cycles in each half and across. Inefficient due to graph traversal.
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


// Optimal Solution (Use DFS with cycle detection)
// The optimal solution uses Depth-First Search (DFS) to detect cycles in the directed graph. We build an adjacency list from the prerequisites, then perform DFS on each unvisited node. During DFS, we use two sets: visited to mark nodes we’ve fully explored and recStack to track nodes in the current recursion path. If we encounter a node already in recStack, there’s a cycle, and we return false. This efficiently checks for cycles in a single traversal.
// Time Complexity: O(V + E) - Visit each vertex (V) and edge (E) once.
// Space Complexity: O(V) - Space for the graph, visited set, and recursion stack.

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
        if (recStack.Contains(node)) return false; // Cycle detected
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

// Example usage
// int[][] prerequisites = { new int[] { 1, 0 } };
// bool result = new OptimalCourseSchedule().CanFinish(2, prerequisites); // Output: true