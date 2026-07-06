public class Solution {
    public bool IsValid(string s) {
        var stack = new Stack<char>();
        var parens = new Dictionary<char, char>()
        {
            { '(', ')' },
            { '{', '}' },
            { '[', ']' }
        };

        foreach (char c in s)
        {
            // Opening bracket → push the matching closer we expect to see later
            if (parens.TryGetValue(c, out char value)) stack.Push(value);
            // Closing bracket → TryPop returns false if stack is empty (unmatched closer),
            // then || short-circuits; if pop succeeds, check it matches current char
            else if (!stack.TryPop(out char val) || val != c) return false;
        }

        // If stack isn't empty, we have unmatched openers
        return stack.Count == 0;
    }
}
