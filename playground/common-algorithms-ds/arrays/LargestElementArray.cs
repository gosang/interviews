// Kth Largest Element in an Array
// Problem: Find the kth largest element in an unsorted array.


// Brute Force Solution
// The brute force approach sorts the entire array in ascending order, then returns the element at index n - k (where n is the array length). This is simple but inefficient because sorting the whole array is overkill when we only need the kth largest element.
// Time Complexity: O(n log n) - Sorting the array.
// Space Complexity: O(1) - In-place sorting (assuming Array.Sort modifies the input).

public class BruteForceFindKthLargest {
    public int FindKthLargestBruteForce(int[] nums, int k) {
        Array.Sort(nums);
        return nums[nums.Length - k];
    }
}

// Divide-and-Conquer Solution
// Explanation: Use quickselect with partitioning.
// Time Complexity: O(n) average, Space Complexity: O(1)

public class DivideConquerFindKthLargest {
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

// Optimal Solution (Use a min-heap of size k)
// The optimal solution uses a min-heap of size k. We iterate through the array, adding each element to the heap. If the heap size exceeds k, we remove the smallest element. At the end, the heap contains the k largest elements, and the top is the kth largest. This is more efficient than sorting because heap operations are logarithmic in k, not n, and k is typically smaller than n.
// Time Complexity: O(n log k) - O(n) elements, each with O(log k) heap operations.
// Space Complexity: O(k) - Heap stores k elements.

public class OptimalFindKthLargest {
    public int FindKthLargest(int[] nums, int k) {
        var pq = new PriorityQueue<int, int>(Comparer<int>.Create((a, b) => a - b)); // Min-heap
        foreach (int num in nums) {
            pq.Enqueue(num, num);
            if (pq.Count > k) pq.Dequeue();
        }
        return pq.Dequeue();
    }
}

// Example usage
// int[] nums = { 3, 2, 1, 5, 6, 4 };
// int k = 2;
// int result = new OptimalFindKthLargest().FindKthLargest(nums, k); // Output: 5