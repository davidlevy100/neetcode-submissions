public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        var seen = new Dictionary<int,int>();

        for (int i = 0; i < nums.Length; i++) {
            // check if current number matches one we’ve stored
            if (seen.TryGetValue(nums[i], out int j)) {
                return new[] { j, i };
            }
            // store the index of the complement for future hits
            seen[target - nums[i]] = i;
        }

        // by problem constraints this should never happen—
        // but we need something that compiles
        throw new ArgumentException("No two-sum solution");
    }
}