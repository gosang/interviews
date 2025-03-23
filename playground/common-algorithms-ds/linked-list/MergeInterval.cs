// Problem: Given a collection of intervals (e.g., [[1,3],[2,6],[8,10],[15,18]]), merge all overlapping intervals and return the result.

// Brute Force Solution
// In the brute force approach, we start with the list of intervals and repeatedly compare each interval with every other to check for overlaps. If two intervals overlap (i.e., the start of one is less than or equal to the end of the other), we merge them by taking the minimum start and maximum end, remove the second interval, and continue this process until no more merges are possible. This is inefficient because it requires multiple passes over the list and repeated comparisons, even after merging.

// Time Complexity: O(n²) - Each interval may need to be compared with all others, and this process repeats until no overlaps remain.
// Space Complexity: O(n) - We store the merged intervals in a list, which can grow or shrink but is bounded by the input size.

public class BruteForceMergeIntervals {
    public int[][] MergeBruteForce(int[][] intervals) {
        List<int[]> result = new List<int[]>(intervals);
        bool changed;
        do {
            changed = false;
            for (int i = 0; i < result.Count; i++) {
                for (int j = i + 1; j < result.Count; j++) {
                    if (Overlaps(result[i], result[j])) {
                        result[i] = new int[] { Math.Min(result[i][0], result[j][0]), Math.Max(result[i][1], result[j][1]) };
                        result.RemoveAt(j);
                        changed = true;
                        break;
                    }
                }
                if (changed) break;
            }
        } while (changed);
        return result.ToArray();
    }
    
    private bool Overlaps(int[] a, int[] b) {
        return a[0] <= b[1] && b[0] <= a[1];
    }
}


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