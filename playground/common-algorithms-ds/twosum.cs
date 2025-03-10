// Problem: Given an array nums and integer target, return indices of two numbers that sum to target.

// Divide-and-Conquer Solution
// Explanation: Split the array into two halves, recursively search for pairs within each half, 
// and check pairs across the split. This is less efficient than the optimal solution due to unnecessary recursion.
// Time Complexity: O(n log n), Space Complexity: O(log n) for recursion stack.

public class DivideConquerSolution {
    public int[] TwoSumDivideConquer(int[] nums, int target) {
        return TwoSumHelper(nums, target, 0, nums.Length - 1);
    }
    
    private int[] TwoSumHelper(int[] nums, int target, int left, int right) {
        if (left >= right) return [];
        
        int mid = left + (right - left) / 2;
        int[] leftResult = TwoSumHelper(nums, target, left, mid);
        if (leftResult.Length > 0) return leftResult;
        
        int[] rightResult = TwoSumHelper(nums, target, mid + 1, right);
        if (rightResult.Length > 0) return rightResult;
        
        for (int i = left; i <= mid; i++) {
            for (int j = mid + 1; j <= right; j++) {
                if (nums[i] + nums[j] == target) return [i, j];
            }
        }
        return [];
    }
}


// Optimal Solution
// Explanation: Use a hash table to store complements, achieving linear time.
// Time Complexity: O(n), Space Complexity: O(n)

public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        Dictionary<int, int> numMap = new Dictionary<int, int>();
        for (int i = 0; i < nums.Length; i++) {
            int complement = target - nums[i];
            if (numMap.ContainsKey(complement)) return [numMap[complement], i];
            numMap[nums[i]] = i;
        }
        return [];
    }
}


// Example
// int[] nums = { 2, 7, 11, 15 };
// int target = 9;
// int[] result = new Solution().TwoSum(nums, target); // [0, 1]