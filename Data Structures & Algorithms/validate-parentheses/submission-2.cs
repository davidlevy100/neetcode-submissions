public class Solution {
    public bool IsValid(string s) {
        
        Stack<char> stack = new();
        Dictionary<char, char> map = new()
        {
            { '(', ')' },
            { '{', '}' },
            { '[', ']' }
        };

        foreach (char c in s) {
            if (map.ContainsKey(c)) stack.Push(map[c]);
            else if (stack.Count == 0 || stack.Pop() != c) return false;
        }

        return stack.Count == 0;

    }
}
