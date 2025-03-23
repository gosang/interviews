// Top K Frequent Elements
// Problem: Return the k most frequent elements in an array.


// Divide-and-Conquer Solution
// Explanation: Split the array, count frequencies in each half, and merge top k. Inefficient due to redundant counting.
// Time Complexity: O(n log n), Space Complexity: O(n)

public class DivideConquerFrequentElement {
    public int[] TopKFrequentDivideConquer(int[] nums, int k) {
        return TopKHelper(nums, 0, nums.Length - 1, k);
    }
    
    private int[] TopKHelper(int[] nums, int left, int right, int k) {
        if (left > right) return new int[0];
        if (left == right) return new int[] { nums[left] };
        
        int mid = left + (right - left) / 2;
        var leftFreq = CountFrequencies(nums, left, mid);
        var rightFreq = CountFrequencies(nums, mid + 1, right);
        
        var mergedFreq = new Dictionary<int, int>(leftFreq);
        foreach (var kvp in rightFreq) {
            mergedFreq[kvp.Key] = mergedFreq.GetValueOrDefault(kvp.Key, 0) + kvp.Value;
        }
        
        return mergedFreq.OrderByDescending(x => x.Value).Take(k).Select(x => x.Key).ToArray();
    }
    
    private Dictionary<int, int> CountFrequencies(int[] nums, int start, int end) {
        var freq = new Dictionary<int, int>();
        for (int i = start; i <= end; i++) {
            freq[nums[i]] = freq.GetValueOrDefault(nums[i], 0) + 1;
        }
        return freq;
    }
}


// Optimal Solution
// Explanation: Use a dictionary and min-heap for O(n log k) time.
// Time Complexity: O(n log k), Space Complexity: O(n)


public class OptimalFrequentElement {
    public int[] TopKFrequent(int[] nums, int k) {
        var count = new Dictionary<int, int>();
        foreach (int num in nums) {
            count[num] = count.GetValueOrDefault(num, 0) + 1;
        }
        
        var pq = new PriorityQueue<int, int>(Comparer<int>.Create((a, b) => a - b));
        foreach (var kvp in count) {
            pq.Enqueue(kvp.Key, kvp.Value);
            if (pq.Count > k) pq.Dequeue();
        }
        
        int[] result = new int[k];
        for (int i = k - 1; i >= 0; i--) {
            result[i] = pq.Dequeue();
        }
        return result;
    }
}