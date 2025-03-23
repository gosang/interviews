// Valid Parentheses
// Problem: Check if a string of brackets is valid.
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