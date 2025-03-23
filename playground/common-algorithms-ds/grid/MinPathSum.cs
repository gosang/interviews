//  Minimum Path Sum
// Problem: Find the minimum path sum from top-left to bottom-right in a grid (right/down moves only).

// Brute Force Solution
// The brute force approach recursively explores all possible paths from (0,0) to (m-1,n-1) by moving right or down. At each cell, we compute the minimum path sum by adding the current cell’s value to the minimum of the recursive calls for the down and right paths. This is inefficient because it recomputes overlapping subproblems exponentially, with no memoization.
// Time Complexity: O(2^(m+n)) - Each cell branches into two paths, leading to exponential growth.
// Space Complexity: O(m + n) - Recursion stack depth.

public class BruteForceMinPathSum {
    public int MinPathSumBruteForce(int[][] grid) {
        return MinPathHelper(grid, 0, 0);
    }
    
    private int MinPathHelper(int[][] grid, int i, int j) {
        if (i == grid.Length - 1 && j == grid[0].Length - 1) return grid[i][j];
        if (i >= grid.Length || j >= grid[0].Length) return int.MaxValue;
        
        int down = MinPathHelper(grid, i + 1, j);
        int right = MinPathHelper(grid, i, j + 1);
        return grid[i][j] + Math.Min(down, right);
    }
}


// Divide-and-Conquer Solution
// Explanation: Recursively compute min path by exploring all possibilities.
// Time Complexity: O(2^(m+n)), Space Complexity: O(m + n)

public class DivideConquerMinPathSum {
    public int MinPathSumDivideConquer(int[][] grid) {
        return MinPathHelper(grid, 0, 0);
    }
    
    private int MinPathHelper(int[][] grid, int i, int j) {
        if (i == grid.Length - 1 && j == grid[0].Length - 1) return grid[i][j];
        if (i >= grid.Length || j >= grid[0].Length) return int.MaxValue;
        
        int down = MinPathHelper(grid, i + 1, j);
        int right = MinPathHelper(grid, i, j + 1);
        return grid[i][j] + Math.Min(down, right);
    }
}


// Optimal Solution
// Explanation: Use dynamic programming with a 2D array.
// Time Complexity: O(m * n), Space Complexity: O(m * n)


public class OptimalMinPathSum {
    public int MinPathSum(int[][] grid) {
        int m = grid.Length, n = grid[0].Length;
        int[,] dp = new int[m, n];
        dp[0, 0] = grid[0][0];
        
        for (int i = 1; i < m; i++) dp[i, 0] = dp[i - 1, 0] + grid[i][0];
        for (int j = 1; j < n; j++) dp[0, j] = dp[0, j - 1] + grid[0][j];
        
        for (int i = 1; i < m; i++) {
            for (int j = 1; j < n; j++) {
                dp[i, j] = grid[i][j] + Math.Min(dp[i - 1, j], dp[i, j - 1]);
            }
        }
        return dp[m - 1, n - 1];
    }
}
