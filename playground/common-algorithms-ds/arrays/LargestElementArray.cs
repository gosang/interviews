// Kth Largest Element in an Array
// Problem: Find the kth largest element in an unsorted array.

// Divide-and-Conquer Solution
// Explanation: Use quickselect with partitioning.
// Time Complexity: O(n) average, Space Complexity: O(1)

public class DivideConquerFindKthLarges {
    public int FindKthLargestDivideConquer(int[] nums, int k) {
        return QuickSelect(nums, 0, nums.Length - 1, nums.Length - k);
    }
    
    private int QuickSelect(int[] nums, int left, int right, int k) {
        if (left == right) return nums[left];
        
        int pivotIndex = Partition(nums, left, right);
        if (pivotIndex == k) return nums[pivotIndex];
        else if (pivotIndex < k) return QuickSelect(nums, pivotIndex + 1, right, k);
        else return QuickSelect(nums, left, pivotIndex - 1, k);
    }
    
    private int Partition(int[] nums, int left, int right) {
        int pivot = nums[right], i = left - 1;
        for (int j = left; j < right; j++) {
            if (nums[j] <= pivot) Swap(nums, ++i, j);
        }
        Swap(nums, i + 1, right);
        return i + 1;
    }
    
    private void Swap(int[] nums, int i, int j) {
        int temp = nums[i];
        nums[i] = nums[j];
        nums[j] = temp;
    }
}

// Optimal Solution
// Explanation: Use a min-heap of size k.
// Time Complexity: O(n log k), Space Complexity: O(k)

public class OptimalFindKthLarges {
    public int FindKthLargest(int[] nums, int k) {
        var pq = new PriorityQueue<int, int>(Comparer<int>.Create((a, b) => a - b));
        foreach (int num in nums) {
            pq.Enqueue(num, num);
            if (pq.Count > k) pq.Dequeue();
        }
        return pq.Dequeue();
    }
}