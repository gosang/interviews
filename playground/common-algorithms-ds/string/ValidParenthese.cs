// Valid Parentheses
// Problem: Given a string s containing (, ), {, }, [, ], determine if it’s valid (brackets close in the correct order).

//Brute Force Solution
// The brute force approach repeatedly scans the string and removes matching pairs of brackets (e.g., "()", "{}", "[]") until no more pairs can be removed. If the string becomes empty, it’s valid; if it stops shrinking but isn’t empty, it’s invalid. This is inefficient because it requires multiple passes over the string, and each pass involves string manipulation, which is costly.
// Time Complexity: O(n²) - Each pass takes O(n) to scan and replace, and up to O(n) passes may be needed.
// Space Complexity: O(n) - New strings are created during replacement.

public class BruteForceValidParanthense{
    public bool IsValidBruteForce(string s) {
        while (s.Length > 0) {
            int len = s.Length;
            s = s.Replace("()", "").Replace("{}", "").Replace("[]", "");
            if (s.Length == len) return false; // No changes, invalid
        }
        return true;
    }
}



// Divide-and-Conquer Solution
// Explanation: Split the string and validate each half, ensuring proper nesting across boundaries. Inefficient due to substring checks.
// Time Complexity: O(n²), Space Complexity: O(n)

public class DivideConquerValidParenthense {
    public bool IsValidDivideConquer(string s) {
        return IsValidHelper(s, 0, s.Length - 1);
    }
    
    private bool IsValidHelper(string s, int left, int right) {
        if (left > right) return true;
        if (left == right) return false;
        
        int mid = left + (right - left) / 2;
        bool leftValid = IsValidHelper(s, left, mid);
        bool rightValid = IsValidHelper(s, mid + 1, right);
        
        if (!leftValid || !rightValid) return false;
        return CheckFullString(s, left, right);
    }
    
    private bool CheckFullString(string s, int left, int right) {
        Stack<char> stack = new Stack<char>();
        for (int i = left; i <= right; i++) {
            if ("({[".Contains(s[i])) stack.Push(s[i]);
            else if (stack.Count == 0 || !Matches(stack.Pop(), s[i])) return false;
        }
        return stack.Count == 0;
    }
    
    private bool Matches(char open, char close) {
        return (open == '(' && close == ')') || (open == '{' && close == '}') || (open == '[' && close == ']');
    }
}


// Optimal Solution
// Explanation: Use a stack for O(n) time.
// Time Complexity: O(n), Space Complexity: O(n)

public class OptimalValidParenthese {
    public bool IsValid(string s) {
        Stack<char> stack = new Stack<char>();
        Dictionary<char, char> pairs = new Dictionary<char, char> { { ')', '(' }, { '}', '{' }, { ']', '[' } };
        
        foreach (char c in s) {
            if (pairs.ContainsValue(c)) stack.Push(c);
            else if (pairs.ContainsKey(c) && (stack.Count == 0 || stack.Pop() != pairs[c])) return false;
        }
        return stack.Count == 0;
    }
}