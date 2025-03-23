// Word Ladder
// Problem: Given a beginWord, endWord, and wordList, find the shortest transformation sequence length by changing one letter at a time.

// Brute Force Solution
// The brute force approach uses recursion to explore all possible transformations from beginWord. For each word, we generate all possible one-letter transformations, check if they’re in the word list, and recursively continue until we reach endWord. We track the minimum length among all valid paths. This is inefficient because it explores an exponential number of paths without pruning, leading to a massive search space.
// Time Complexity: O(26^N) - For each of N positions, try 26 letters, leading to exponential growth.
// Space Complexity: O(N) - Recursion stack depth.

public class BruteForceWordLadder {
    public int LadderLengthBruteForce(string beginWord, string endWord, IList<string> wordList) {
        HashSet<string> wordSet = new HashSet<string>(wordList);
        if (!wordSet.Contains(endWord)) return 0;
        HashSet<string> visited = new HashSet<string>();
        return LadderHelper(beginWord, endWord, wordSet, visited, 1);
    }
    
    private int LadderHelper(string current, string end, HashSet<string> wordSet, HashSet<string> visited, int level) {
        if (current == end) return level;
        if (!wordSet.Contains(current) || visited.Contains(current)) return 0;
        
        visited.Add(current);
        int minLength = 0;
        char[] chars = current.ToCharArray();
        for (int i = 0; i < current.Length; i++) {
            char original = chars[i];
            for (char c = 'a'; c <= 'z'; c++) {
                chars[i] = c;
                string newWord = new string(chars);
                int result = LadderHelper(newWord, end, wordSet, visited, level + 1);
                if (result > 0) minLength = minLength == 0 ? result : Math.Min(minLength, result);
            }
            chars[i] = original;
        }
        visited.Remove(current);
        return minLength;
    }
}


// Divide-and-Conquer Solution
// Not naturally suited; adapt by splitting word list and searching paths. Highly inefficient.
// Time Complexity: O(26^L * N), Space Complexity: O(N)

public class DivideConquerWordLadder {
    public int LadderLengthDivideConquer(string beginWord, string endWord, IList<string> wordList) {
        HashSet<string> wordSet = new HashSet<string>(wordList);
        if (!wordSet.Contains(endWord)) return 0;
        return LadderHelper(beginWord, endWord, wordSet, 1);
    }
    
    private int LadderHelper(string current, string end, HashSet<string> wordSet, int level) {
        if (current == end) return level;
        if (wordSet.Count == 0) return 0;
        
        int minLength = 0;
        foreach (string word in wordSet.ToList()) {
            if (DiffersByOne(current, word)) {
                wordSet.Remove(word);
                int result = LadderHelper(word, end, wordSet, level + 1);
                if (result > 0) minLength = minLength == 0 ? result : Math.Min(minLength, result);
                wordSet.Add(word);
            }
        }
        return minLength;
    }
    
    private bool DiffersByOne(string a, string b) {
        int diff = 0;
        for (int i = 0; i < a.Length; i++) if (a[i] != b[i]) diff++;
        return diff == 1;
    }
}


// Optimal Solution (Use BFS for shortest path)
// The optimal solution uses Breadth-First Search (BFS) to find the shortest transformation sequence, as BFS guarantees the minimum path length in an unweighted graph. We start with beginWord, enqueue it with level 1, and for each word, generate all one-letter transformations. If a transformation is in the word list and unvisited, we enqueue it with the next level. When we reach endWord, we return its level. This is efficient because it explores level by level, stopping at the shortest path.
// Time Complexity: O(N * 26 * L) - N words, L length, 26 letters per position.
// Space Complexity: O(N) - Queue and visited set store up to N words.

public class OptimalWordLadder {
    public int LadderLength(string beginWord, string endWord, IList<string> wordList) {
        HashSet<string> wordSet = new HashSet<string>(wordList);
        if (!wordSet.Contains(endWord)) return 0;
        
        Queue<(string, int)> queue = new Queue<(string, int)>();
        queue.Enqueue((beginWord, 1));
        HashSet<string> visited = new HashSet<string> { beginWord };
        
        while (queue.Count > 0) {
            var (word, level) = queue.Dequeue();
            if (word == endWord) return level;
            
            char[] chars = word.ToCharArray();
            for (int i = 0; i < word.Length; i++) {
                char original = chars[i];
                for (char c = 'a'; c <= 'z'; c++) {
                    chars[i] = c;
                    string newWord = new string(chars);
                    if (wordSet.Contains(newWord) && !visited.Contains(newWord)) {
                        queue.Enqueue((newWord, level + 1));
                        visited.Add(newWord);
                    }
                }
                chars[i] = original;
            }
        }
        return 0;
    }
}

// Example usage
// string beginWord = "hit", endWord = "cog";
// IList<string> wordList = new List<string> { "hot", "dot", "dog", "lot", "log", "cog" };
// int result = new Solution().LadderLength(beginWord, endWord, wordList); // Output: 5