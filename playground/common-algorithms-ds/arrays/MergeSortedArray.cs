// Merge Sorted Array
// Problem: Merge two sorted arrays nums1 (with space) and nums2 into nums1.


// Brute Force Solution
// The brute force approach copies both arrays into a single temporary array, sorts it, and then copies it back to nums1. This ignores the fact that the input arrays are already sorted, making it unnecessarily expensive due to the sorting step. It’s simple but inefficient for this specific problem.
// Time Complexity: O((m + n) log(m + n)) - Sorting the combined array.
// Space Complexity: O(m + n) - Temporary array.

public class BruteForceMergeArray {
    public void MergeBruteForce(int[] nums1, int m, int[] nums2, int n) {
        int[] temp = new int[m + n];
        Array.Copy(nums1, 0, temp, 0, m);
        Array.Copy(nums2, 0, temp, m, n);
        Array.Sort(temp);
        Array.Copy(temp, nums1, m + n);
    }
}


// Divide-and-Conquer Solution
// Explanation: Split and merge recursively like merge sort.
// Time Complexity: O(m + n log(m + n)), Space Complexity: O(m + n)

public class DivideConquerMergeArray {
    public void MergeDivideConquer(int[] nums1, int m, int[] nums2, int n) {
        int[] temp = new int[m + n];
        MergeHelper(nums1, 0, m - 1, nums2, 0, n - 1, temp);
        Array.Copy(temp, nums1, m + n);
    }
    
    private void MergeHelper(int[] nums1, int left1, int right1, int[] nums2, int left2, int right2, int[] temp) {
        if (left1 > right1) {
            Array.Copy(nums2, left2, temp, left1 + left2, right2 - left2 + 1);
            return;
        }
        if (left2 > right2) {
            Array.Copy(nums1, left1, temp, left1 + left2, right1 - left1 + 1);
            return;
        }
        
        int mid1 = left1 + (right1 - left1) / 2;
        int mid2 = left2 + (right2 - left2) / 2;
        
        MergeHelper(nums1, left1, mid1, nums2, left2, mid2, temp);
        MergeHelper(nums1, mid1 + 1, right1, nums2, mid2 + 1, right2, temp);
        MergeArrays(nums1, left1, mid1, right1, nums2, left2, mid2, right2, temp);
    }
    
    private void MergeArrays(int[] nums1, int l1, int m1, int r1, int[] nums2, int l2, int m2, int r2, int[] temp) {
        int i = l1, j = l2, k = l1 + l2;
        while (i <= r1 && j <= r2) temp[k++] = nums1[i] <= nums2[j] ? nums1[i++] : nums2[j++];
        while (i <= r1) temp[k++] = nums1[i++];
        while (j <= r2) temp[k++] = nums2[j++];
    }
}


// Optimal Solution
// Explanation: Merge from the end to avoid extra space.
// Time Complexity: O(m + n), Space Complexity: O(1)

public class OptimalMergeArray {
    public void Merge(int[] nums1, int m, int[] nums2, int n) {
        int p1 = m - 1, p2 = n - 1, p = m + n - 1;
        while (p2 >= 0 && p1 >= 0) {
            nums1[p--] = nums1[p1] > nums2[p2] ? nums1[p1--] : nums2[p2--];
        }
        while (p2 >= 0) nums1[p--] = nums2[p2--];
    }
}