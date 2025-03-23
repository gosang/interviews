// Longest Substring Without Repeating Characters
// Problem: Find the length of the longest substring without repeating characters.

// Divide-and-Conquer Solution
// Explanation: Split the string and check substrings, merging results by considering boundaries. 
// Less efficient due to overlap handling.
// Time Complexity: O(n²), Space Complexity: O(n)


public class DivideConquerLongestSubstring {
    public int LengthOfLongestSubstringDivideConquer(string s) {
        return LongestSubstringHelper(s, 0, s.Length - 1);
    }
    
    private int LongestSubstringHelper(string s, int left, int right) {
        if (left > right) return 0;
        if (left == right) return 1;
        
        int mid = left + (right - left) / 2;
        int leftMax = LongestSubstringHelper(s, left, mid);
        int rightMax = LongestSubstringHelper(s, mid + 1, right);
        
        int crossMax = CrossBoundaryMax(s, left, mid, right);
        return Math.Max(Math.Max(leftMax, rightMax), crossMax);
    }
    
    private int CrossBoundaryMax(string s, int left, int mid, int right) {
        HashSet<char> set = new HashSet<char>();
        int max = 0, start = left;
        for (int i = left; i <= right; i++) {
            if (set.Contains(s[i])) {
                max = Math.Max(max, i - start);
                while (s[start] != s[i]) set.Remove(s[start++]);
                start++;
            } else {
                set.Add(s[i]);
            }
        }
        return Math.Max(max, right - start + 1);
    }
}

// Optimal Solution
// Explanation: Use a sliding window with a dictionary for O(n) time.
// Time Complexity: O(n), Space Complexity: O(min(m, n))

public class LongestSubstring {
    public int LengthOfLongestSubstring(string s) {
        Dictionary<char, int> charIndex = new Dictionary<char, int>();
        int maxLength = 0, start = 0;
        
        for (int end = 0; end < s.Length; end++) {
            if (charIndex.ContainsKey(s[end]) && charIndex[s[end]] >= start) {
                start = charIndex[s[end]] + 1;
            } else {
                maxLength = Math.Max(maxLength, end - start + 1);
            }
            charIndex[s[end]] = end;
        }
        return maxLength;
    }
}

// Example
// string s = "abcabcbb";
// int result = new Solution().LengthOfLongestSubstring(s); // 3