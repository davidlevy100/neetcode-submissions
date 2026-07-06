public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        // Key = complement needed, Value = index of the number that needs it
        var seen = new Dictionary<int, int>();

        for (int k = 0; k < nums.Length; k++)
        {
            // If nums[k] is already a key in seen, a previous number stored it
            // as its complement — meaning nums[k] + that previous number == target
            if (seen.TryGetValue(nums[k], out int value))
            {
                return [value, k];

            } else
            {
                // Store (target - nums[k]) as the key: this is the number we'd
                // need to see in the future to form a pair with nums[k]
                seen[target - nums[k]] = k;
            }
        }

        throw new ArgumentException("no solution found");
    }
}
