// Problem: Merge overlapping intervals from a list like [[1,3],[2,6],[8,10]].
// Divide-and-Conquer Solution
// Explanation: Split intervals into two halves, recursively merge each half, then merge the results across the split. Sorting is still required initially.
// Time Complexity: O(n log n), Space Complexity: O(n)

public class DivideConquerMergeIntervals {
    public int[][] MergeDivideConquer(int[][] intervals) {
        if (intervals.Length <= 1) return intervals;
        Array.Sort(intervals, (a, b) => a[0].CompareTo(b[0]));
        return MergeHelper(intervals, 0, intervals.Length - 1);
    }
    
    private int[][] MergeHelper(int[][] intervals, int left, int right) {
        if (left == right) return new int[][] { intervals[left] };
        
        int mid = left + (right - left) / 2;
        int[][] leftMerged = MergeHelper(intervals, left, mid);
        int[][] rightMerged = MergeHelper(intervals, mid + 1, right);
        return MergeTwo(leftMerged, rightMerged);
    }
    
    private int[][] MergeTwo(int[][] left, int[][] right) {
        List<int[]> result = new List<int[]>(left);
        foreach (var interval in right) {
            int[] last = result[result.Count - 1];
            if (interval[0] <= last[1]) {
                last[1] = Math.Max(last[1], interval[1]);
            } else {
                result.Add(interval);
            }
        }
        return result.ToArray();
    }
}


// Optimal Solution
// Explanation: Sort by start time and merge in a single pass.
// Time Complexity: O(n log n), Space Complexity: O(n)

public class MergeIntervals {
    public int[][] Merge(int[][] intervals) {
        if (intervals.Length == 0) return new int[0][];
        Array.Sort(intervals, (a, b) => a[0].CompareTo(b[0]));
        List<int[]> merged = new List<int[]> { intervals[0] };
        
        for (int i = 1; i < intervals.Length; i++) {
            int[] last = merged[merged.Count - 1];
            if (intervals[i][0] <= last[1]) {
                last[1] = Math.Max(last[1], intervals[i][1]);
            } else {
                merged.Add(intervals[i]);
            }
        }
        return merged.ToArray();
    }
}

// Example
// int[][] intervals = { new int[] { 1, 3 }, new int[] { 2, 6 } };
// int[][] result = new Solution().Merge(intervals); // [[1,6]]