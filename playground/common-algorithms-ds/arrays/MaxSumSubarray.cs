// Maximum Subarray
// Problem: Find the maximum sum of a contiguous subarray.
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
