public class Solution {
    public bool IsHappy(int n) {

        HashSet<int> seen = new();

        while (n != 1) {
            seen.Add(n);
            n = SumOfSquares(n);
            if (seen.Contains(n)) return false;
        }

        return true;
        
    }

    private static int SumOfSquares(int n) {
        int result = 0;

        while (n > 0) {
            int lastDigit = n % 10;
            result += lastDigit * lastDigit;
            n /= 10;
        }

        return result;
    }
}
