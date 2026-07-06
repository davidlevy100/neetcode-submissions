public class Solution {
    public bool IsAnagram(string s, string t) {
        // string.Length is a property (no parens). `char` is a 16-bit UTF-16 code unit.
        if (s.Length != t.Length) return false;

        // Dictionary<TKey,TValue> = .NET hash map. Unlike Go maps, indexing a MISSING
        // key throws (KeyNotFoundException) rather than returning a zero value — hence TryGetValue below.
        var seen = new Dictionary<char, int>();

        foreach(char c in s)
        {
            // C# idiom: TryGetValue(key, out var count) — the `out` parameter is assigned
            // in-place. If the key is missing, `count` gets default(int) == 0. This is the
            // safe "get-or-zero" pattern (avoids the missing-key throw).
            seen.TryGetValue(c, out var count);
            seen[c] = count + 1;          // indexer set: creates the key if absent, overwrites if present.
        }

        foreach(char c in t)
        {
            // TryGetValue also RETURNS a bool (found / not found). Char in t not in s => not an anagram.
            if (!seen.TryGetValue(c, out var count)) return false;

            seen[c] = count - 1;

            if (seen[c] < 0) return false;

        }

        return true;
    }
}
