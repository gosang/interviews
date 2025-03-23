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


// Optimal Solution
// Explanation: Kadane’s algorithm for O(n) time.
// Time Complexity: O(n), Space Complexity: O(1)


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
