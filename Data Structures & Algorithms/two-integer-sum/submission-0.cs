public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        Dictionary<int, int> seen = new();

        for (int index = 0; index < nums.Length; index++) {
            int num = nums[index];

            if (seen.ContainsKey(num)) {
                return new int[] { seen[num], index };
            }

            seen[target - num] = index;
        }

        throw new InvalidOperationException("No solution found"); // Handles cases where no solution exists
    }
}