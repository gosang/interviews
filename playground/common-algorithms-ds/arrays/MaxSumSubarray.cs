// Maximum Subarray
// Problem: Given an integer array nums, find the contiguous subarray with the largest sum.

// Brute Force Solution
// The brute force approach computes the sum of every possible subarray by using two nested loops to define start and end indices. For each subarray, we calculate its sum and update the maximum sum if it’s larger. This is inefficient because it checks all O(n²) subarrays, even though many could be skipped with a smarter approach.
// Time Complexity: O(n²) - O(n) start points, O(n) end points per start.
// Space Complexity: O(1) - Only stores the maximum sum.

public class BruteForceMaxSubarray{
    public int MaxSubArrayBruteForce(int[] nums) {
        int maxSum = nums[0];
        for (int i = 0; i < nums.Length; i++) {
            int sum = 0;
            for (int j = i; j < nums.Length; j++) {
                sum += nums[j];
                maxSum = Math.Max(maxSum, sum);
            }
        }
        return maxSum;
    }
}


// Divide-and-Conquer Solution
// Explanation: Split the array, compute max subarray in left, right, and across the middle.
// Time Complexity: O(n log n), Space Complexity: O(log n)

public class DivideConquerMaxSubarray {
    public int MaxSubArrayDivideConquer(int[] nums) {
        return MaxSubArrayHelper(nums, 0, nums.Length - 1);
    }
    
    private int MaxSubArrayHelper(int[] nums, int left, int right) {
        if (left == right) return nums[left];
        
        int mid = left + (right - left) / 2;
        int leftMax = MaxSubArrayHelper(nums, left, mid);
        int rightMax = MaxSubArrayHelper(nums, mid + 1, right);
        int crossMax = CrossMax(nums, left, mid, right);
        
        return Math.Max(Math.Max(leftMax, rightMax), crossMax);
    }
    
    private int CrossMax(int[] nums, int left, int mid, int right) {
        int leftSum = int.MinValue, rightSum = int.MinValue, sum = 0;
        for (int i = mid; i >= left; i--) {
            sum += nums[i];
            leftSum = Math.Max(leftSum, sum);
        }
        sum = 0;
        for (int i = mid + 1; i <= right; i++) {
            sum += nums[i];
            rightSum = Math.Max(rightSum, sum);
        }
        return leftSum + rightSum;
    }
}


// Optimal Solution (Kadane’s algorithm for O(n) time)
// The optimal solution uses Kadane’s algorithm, which scans the array once and keeps track of the maximum sum ending at each position (maxEndingHere) and the overall maximum sum (maxSoFar). At each step, we decide whether to start a new subarray at the current element or extend the existing subarray by adding the current element, taking the maximum of these options. This avoids recomputing sums for all subarrays and solves the problem efficiently.
// Time Complexity: O(n) - Single pass through the array.
// Space Complexity: O(1) - Only two variables are used.

public class OptimalMaxSubarray {
    public int MaxSubArray(int[] nums) {
        int maxSoFar = nums[0], maxEndingHere = nums[0];
        for (int i = 1; i < nums.Length; i++) {
            maxEndingHere = Math.Max(nums[i], maxEndingHere + nums[i]);
            maxSoFar = Math.Max(maxSoFar, maxEndingHere);
        }
        return maxSoFar;
    }
}

// Example usage
// int[] nums = { -2, 1, -3, 4, -1, 2, 1, -5, 4 };
// int result = new OptimalMaxSubarray().MaxSubArray(nums); // Output: 6 ([4,-1,2,1])