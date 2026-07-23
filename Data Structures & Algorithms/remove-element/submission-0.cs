public class Solution {
    public int RemoveElement(int[] nums, int val)
    {
        // slow = next open write slot for a survivor; also doubles as the
        // running count of survivors, so it's the return value at the end
        int slow = 0;

        foreach (int n in nums)
        {
            if (n != val)
            {
                // keeper: copy it forward into the next open slot, then
                // advance that slot. if no val has been skipped yet, this
                // is a harmless self-overwrite (slow == current index)
                nums[slow] = n;
                slow++;
            }
            // n == val: skip it — slow stays put, leaving this slot open
            // for the next keeper to fill. no action needed here at all
        }

        return slow;
    }
}