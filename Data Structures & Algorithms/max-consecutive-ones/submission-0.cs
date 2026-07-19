public class Solution {
    public int FindMaxConsecutiveOnes(int[] nums)
    {
        // thisSeries = length of the run of 1s we're currently inside
        // result = longest run seen so far
        int thisSeries = 0;
        int result = 0;

        foreach (int i in nums)
        {
            if (i == 1)
            {
                // extend the current run
                thisSeries++;
            }
            else
            {
                // run just broke — checkpoint it against the best, then reset
                result = Math.Max(thisSeries, result);
                thisSeries = 0;
            }
        }

        // the array can end mid-run (or be all 1s), so the last streak
        // never hits the else branch above — checkpoint it one more time
        result = Math.Max(thisSeries, result);

        return result;
    }
}