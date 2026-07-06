public class Solution {
    public int[] PlusOne(int[] digits) {

        for (int i = digits.Length-1; i >= 0; i--) {
            int val = digits[i] + 1;

            if (val <= 9) {
                digits[i] = val;
                return digits;
            } else {
                digits[i] = 0;
            }

        }
        
        int[] result = new int[digits.Length + 1];
        result[0] = 1;
        return result;

    }
}
