public class Solution
{
    public bool IsPalindrome(string s)
    {
        for (int l = 0, r = s.Length - 1; l < r; l++, r--)
        {
            while (l < r && !char.IsLetterOrDigit(s[l])) l++;
            while (l < r && !char.IsLetterOrDigit(s[r])) r--;

            if (l < r && char.ToLowerInvariant(s[l]) != char.ToLowerInvariant(s[r]))
                return false;
        }

        return true;
    }

}
