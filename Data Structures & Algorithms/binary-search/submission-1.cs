public class Solution {
    public int Search(int[] nums, int target) {
        // l and r are the window state — declared before the loop so they persist and
        // narrow across iterations. Mental model: "the bounds are still candidates."
        // r starts at the LAST valid index (Length - 1), because that index could be the answer.
        int l = 0, r = nums.Length - 1;

        // l <= r, not l < r: when l == r there's still one candidate left to check.
        while (l <= r)
        {
            // Recomputed each pass (so it goes inside the loop). "Half the gap, from the left."
            // Written as l + (r - l) / 2 rather than (l + r) / 2 to avoid integer overflow
            // when l and r are both large — (l + r) could exceed int.MaxValue and wrap negative.
            var mid = l + (r - l) / 2;

            if (nums[mid] == target) return mid;
            // We just checked mid, so it's no longer a candidate — exclude it with ±1.
            // "mid too big? shrink from the right": value overshot the target, so the answer
            // is in the lower half.
            else if (nums[mid] > target) r = mid - 1;
            // Otherwise the value undershot — answer is in the upper half.
            else l = mid + 1;
        }

        // Window collapsed without a hit — target isn't present.
        return -1;
    }
}
