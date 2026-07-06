public class Solution
{
    public bool IsAnagram(string s, string t)
    {
        // Base case: If lengths are different, they can't be anagrams.
        if (s.Length != t.Length)
        {
            return false;
        }

        Dictionary<char, int> seen = new Dictionary<char, int>();

        // Count occurrences in `s`
        foreach (char letter in s)
        {
            seen[letter] = seen.GetValueOrDefault(letter, 0) + 1;
        }

        // Subtract occurrences based on `t`
        foreach (char letter in t)
        {
            seen[letter] = seen.GetValueOrDefault(letter, 0) - 1;

            // If count goes negative, `t` has more occurrences than `s`
            if (seen[letter] < 0)
            {
                return false;
            }
        }

        return true;
    }
}
