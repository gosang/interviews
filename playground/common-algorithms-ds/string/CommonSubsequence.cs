// Longest Common Subsequence
// Problem: Find the length of the longest common subsequence between two strings.

// Divide-and-Conquer Solution
// Explanation: Split strings and compute LCS recursively.
// Time Complexity: O(2^(m+n)), Space Complexity: O(m + n)

public class DivideConquerCommonSubsequence {
    public int LongestCommonSubsequenceDivideConquer(string text1, string text2) {
        return LcsHelper(text1, text2, text1.Length - 1, text2.Length - 1);
    }
    
    private int LcsHelper(string text1, string text2, int i, int j) {
        if (i < 0 || j < 0) return 0;
        
        if (text1[i] == text2[j]) return 1 + LcsHelper(text1, text2, i - 1, j - 1);
        return Math.Max(LcsHelper(text1, text2, i - 1, j), LcsHelper(text1, text2, i, j - 1));
    }
}

// Optimal Solution

// Explanation: Use dynamic programming with a 2D array.
// Time Complexity: O(m * n), Space Complexity: O(m * n)

public class OptimalCommonSubsequence {
    public int LongestCommonSubsequence(string text1, string text2) {
        int m = text1.Length, n = text2.Length;
        int[,] dp = new int[m + 1, n + 1];
        
        for (int i = 1; i <= m; i++) {
            for (int j = 1; j <= n; j++) {
                if (text1[i - 1] == text2[j - 1]) dp[i, j] = dp[i - 1, j - 1] + 1;
                else dp[i, j] = Math.Max(dp[i - 1, j], dp[i, j - 1]);
            }
        }
        return dp[m, n];
    }
}