// Binary Tree Level Order Traversal
// Problem: Return level-order traversal of a binary tree.

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
// Explanation: Use BFS with a queue for O(n) time.
// Time Complexity: O(n), Space Complexity: O(w)

public class OptimalLevelOrder {
    public IList<IList<int>> LevelOrder(TreeNode root) {
        var result = new List<IList<int>>();
        if (root == null) return result;
        
        var queue = new Queue<TreeNode>();
        queue.Enqueue(root);
        
        while (queue.Count > 0) {
            var levelSize = queue.Count;
            var currentLevel = new List<int>();
            
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

