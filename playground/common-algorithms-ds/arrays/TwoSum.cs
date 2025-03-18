// Problem: Given an array nums and an integer target, return the indices of two numbers that add up to the target. 
// Assume there’s exactly one solution, and you can’t use the same element twice.


// Brute Force Solution
// Explanation: The brute force approach involves checking every possible pair of numbers in the array to see if 
// their sum equals the target. We use two nested loops: the outer loop picks the first number, 
// and the inner loop picks the second number from the remaining elements. If a pair sums to the target, 
// we return their indices. This is straightforward but inefficient because it examines all possible combinations 
// without leveraging any data structure to optimize lookups.

// Time Complexity: O(n²) - The outer loop runs n times, and the inner loop runs up to n-1 times, 
// leading to a quadratic number of comparisons.
// Space Complexity: O(1) - Only a constant amount of extra space is used for variables, regardless of input size.


public class BruteForceTwoSum{
    public static int[] TwoSumBruteForce(int[] nums, int target) {
        for (int i = 0; i < nums.Length; i++) {
            for (int j = i + 1; j < nums.Length; j++) {
                if (nums[i] + nums[j] == target) {
                    return new int[] { i, j };
                }
            }
        }
        return []; // No solution found
    }
}


// Optimal Solution
// Explanation: The optimal solution uses a hash table (Dictionary in C#) to store numbers and their indices 
// as we iterate through the array. For each number, we compute its complement (target - current number) 
// and check if it exists in the hash table. If it does, we’ve found a pair, and we return their indices. 
// If not, we add the current number and its index to the hash table. This approach reduces the problem 
// to a single pass with constant-time lookups, making it far more efficient than brute force.

// Time Complexity: O(n) - We iterate through the array once, and hash table operations (lookup and insertion) 
// are O(1) on average.
// Space Complexity: O(n) - The hash table stores up to n elements in the worst case.


public class OptimalTwoSum {
    public int[] TwoSum(int[] nums, int target) {
        Dictionary<int, int> numMap = new Dictionary<int, int>();
        for (int i = 0; i < nums.Length; i++) {
            int complement = target - nums[i];
            if (numMap.ContainsKey(complement)) {
                return new int[] { numMap[complement], i };
            }
            numMap[nums[i]] = i;
        }
        return []; // No solution found
    }
}

// Example
// int[] nums = { 2, 7, 11, 15 };
// int target = 9;
// int[] result = new OptimalTwoSum().TwoSum(nums, target); // [0, 1]


// Divide-and-Conquer Solution
// Explanation: Split the array into two halves, recursively search for pairs within each half, 
// and check pairs across the split. This is less efficient than the optimal solution due to unnecessary recursion.
// Time Complexity: O(n log n), Space Complexity: O(log n) for recursion stack.

public class DivideConquerTwoSum {
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

