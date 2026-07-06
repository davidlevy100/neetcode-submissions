public class Solution {
    public int[] TwoSum(int[] nums, int target) {

        Dictionary<int, int> seen = new();

        for (int i = 0; i < nums.Length; i++) {
            int complement = target - nums[i];

            if (seen.ContainsKey(complement)) {
                return new[] {seen[complement], i};
            }

            seen[nums[i]] = i;
        }

        throw new InvalidOperationException("No solution found");

    }
}
