public class Solution
{
    public bool IsPalindrome(string s)
    {
        int l = 0;
        int r = s.Length - 1;

        while (l < r)
        {
            // Move left pointer forward until we hit a letter or digit.
            while (l < r && !Char.IsLetterOrDigit(s[l]))
                l++;

            // Move right pointer backward until we hit a letter or digit.
            while (l < r && !Char.IsLetterOrDigit(s[r]))
                r--;

            // If pointers have crossed, we’re done.
            if (l >= r)
                break;

            // Compare case-insensitive.
            if (Char.ToLower(s[l]) != Char.ToLower(s[r]))
                return false;

            l++;
            r--;
        }

        return true;
    }
}
