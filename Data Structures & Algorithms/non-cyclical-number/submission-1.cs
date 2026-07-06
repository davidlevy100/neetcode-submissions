public class Solution {
    public bool IsHappy(int n) {

        HashSet<int> seen = new HashSet<int>();

        while(n > 1) {

            if (seen.Contains(n)) {
                return false;
            }

            seen.Add(n);
            n = sumDigits(n);
        }

        return true;
        
    }

    public int sumDigits(int n) {

        int result = 0;

        while(n > 0) {
            int digit = n%10;
            result += digit * digit;
            n /= 10;
        }

        return result;

    }

}
