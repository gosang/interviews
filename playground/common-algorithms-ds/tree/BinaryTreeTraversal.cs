// Binary Tree Level Order Traversal
// Problem: Given a binary tree, return its level-order traversal (left to right, level by level).

// Brute Force Solution
// The brute force approach first calculates the height of the tree to determine the number of levels. Then, for each level, it performs a preorder traversal, collecting nodes at that specific level into a list. This is inefficient because it requires multiple traversals of the tree (one per level) and doesn’t take advantage of a queue-based approach to process nodes level by level in a single pass.

// Time Complexity: O(n * h) - O(n) nodes visited per level, and h levels (h ≈ log n for balanced trees, n for skewed).
// Space Complexity: O(n) - Store the result list, plus O(h) recursion stack.

public class BruteForceOrderLevel {
     public IList<IList<int>> LevelOrderBruteForce(TreeNode root) {
        List<IList<int>> result = new List<IList<int>>();
        if (root == null) return result;
        
        int height = GetHeight(root);
        for (int level = 0; level < height; level++) {
            List<int> currentLevel = new List<int>();
            CollectLevel(root, level, 0, currentLevel);
            result.Add(currentLevel);
        }
        return result;
    }
    
    private int GetHeight(TreeNode node) {
        if (node == null) return 0;
        return 1 + Math.Max(GetHeight(node.left), GetHeight(node.right));
    }
    
    private void CollectLevel(TreeNode node, int targetLevel, int currentLevel, List<int> level) {
        if (node == null) return;
        if (currentLevel == targetLevel) level.Add(node.val);
        CollectLevel(node.left, targetLevel, currentLevel + 1, level);
        CollectLevel(node.right, targetLevel, currentLevel + 1, level);
    }
}


// Divide-and-Conquer Solution
// Explanation: Recursively process left and right subtrees, merging levels. Less efficient than BFS.
// Time Complexity: O(n log n), Space Complexity: O(n)


public class DivideConquerOrderLevel {
    public IList<IList<int>> LevelOrderDivideConquer(TreeNode root) {
        return (IList<IList<int>>)LevelOrderHelper(root, 0).Values.ToList();
    }
    
    private Dictionary<int, List<int>> LevelOrderHelper(TreeNode node, int level) {
        var result = new Dictionary<int, List<int>>();
        if (node == null) return result;
        
        result[level] = new List<int> { node.val };
        var leftLevels = LevelOrderHelper(node.left, level + 1);
        var rightLevels = LevelOrderHelper(node.right, level + 1);
        
        foreach (var kvp in leftLevels) {
            if (!result.ContainsKey(kvp.Key)) result[kvp.Key] = new List<int>();
            result[kvp.Key].AddRange(kvp.Value);
        }
        foreach (var kvp in rightLevels) {
            if (!result.ContainsKey(kvp.Key)) result[kvp.Key] = new List<int>();
            result[kvp.Key].AddRange(kvp.Value);
        }
        return result;
    }
}


// Optimal Solution

// The optimal solution uses Breadth-First Search (BFS) with a queue. We start by enqueuing the root, then process nodes level by level. For each level, we dequeue all nodes at that level (using the queue’s size to determine the level size), add their values to a list, and enqueue their children. This ensures each node is visited exactly once in level order, making it far more efficient than multiple traversals.
// Time Complexity: O(n) - Each node is enqueued and dequeued once.
// Space Complexity: O(w) - Queue holds at most the maximum width of the tree (w), plus O(n) for the result.

public class OptimalLevelOrder {
    public IList<IList<int>> LevelOrder(TreeNode root) {
        List<IList<int>> result = new List<IList<int>>();
        if (root == null) return result;
        
        Queue<TreeNode> queue = new Queue<TreeNode>();
        queue.Enqueue(root);
        
        while (queue.Count > 0) {
            int levelSize = queue.Count;
            List<int> currentLevel = new List<int>();
            
            for (int i = 0; i < levelSize; i++) {
                TreeNode node = queue.Dequeue();
                currentLevel.Add(node.val);
                if (node.left != null) queue.Enqueue(node.left);
                if (node.right != null) queue.Enqueue(node.right);
            }
            result.Add(currentLevel);
        }
        return result;
    }
}

// Example usage
// TreeNode root = new TreeNode(3, new TreeNode(9), new TreeNode(20, new TreeNode(15), new TreeNode(7)));
// var result = new Solution().LevelOrder(root); // Output: [[3],[9,20],[15,7]]
