// Search in Rotated Sorted Array
// Problem: Search for a target in a rotated sorted array.


// Brute Force Solution
// The brute force approach performs a linear search through the array, checking each element until the target is found or the end is reached. This ignores the rotated sorted property, making it inefficient despite its simplicity.
// Time Complexity: O(n) - Single pass through the array.
// Space Complexity: O(1) - No extra space.

public class BruteForceSearchRotateArray {
     public int SearchBruteForce(int[] nums, int target) {
        for (int i = 0; i < nums.Length; i++) {
            if (nums[i] == target) return i;
        }
        return -1;
    }
}


// Divide-and-Conquer Solution
// Explanation: Use binary search with rotation handling.
// Time Complexity: O(log n), Space Complexity: O(log n)

public class DivideConquerSearchRotateArray {
    public int SearchDivideConquer(int[] nums, int target) {
        return SearchHelper(nums, target, 0, nums.Length - 1);
    }
    
    private int SearchHelper(int[] nums, int target, int left, int right) {
        if (left > right) return -1;
        
        int mid = left + (right - left) / 2;
        if (nums[mid] == target) return mid;
        
        if (nums[left] <= nums[mid]) {
            if (nums[left] <= target && target < nums[mid]) return SearchHelper(nums, target, left, mid - 1);
            return SearchHelper(nums, target, mid + 1, right);
        } else {
            if (nums[mid] < target && target <= nums[right]) return SearchHelper(nums, target, mid + 1, right);
            return SearchHelper(nums, target, left, mid - 1);
        }
    }
}


// Optimal Solution

// Explanation: Iterative binary search with rotation handling.
// Time Complexity: O(log n), Space Complexity: O(1)

public class OptimalSearchRotateArray {
    public int Search(int[] nums, int target) {
        int left = 0, right = nums.Length - 1;
        while (left <= right) {
            int mid = left + (right - left) / 2;
            if (nums[mid] == target) return mid;
            
            if (nums[left] <= nums[mid]) {
                if (nums[left] <= target && target < nums[mid]) right = mid - 1;
                else left = mid + 1;
            } else {
                if (nums[mid] < target && target <= nums[right]) left = mid + 1;
                else right = mid - 1;
            }
        }
        return -1;
    }
}

