public class Solution
{
    public bool IsAnagram(string s, string t)
    {
        // Quick reject: different lengths can't be anagrams
        if (s.Length != t.Length)
            return false;

        // Frequency table for chars
        var counts = new Dictionary<char, int>();

        // Count characters from s
        foreach (char c in s)
        {
            if (counts.ContainsKey(c))
                counts[c]++;
            else
                counts[c] = 1;
        }

        // Subtract characters from t
        foreach (char c in t)
        {
            // If t has a char that s doesn't
            if (!counts.ContainsKey(c))
                return false;

            counts[c]--;

            // If count goes negative, mismatch
            if (counts[c] < 0)
                return false;
        }

        // All counts must be zero
        return true;
    }
}
