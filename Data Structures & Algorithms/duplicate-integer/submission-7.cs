public class Solution {
    public bool hasDuplicate(int[] nums) {
        var seen = new HashSet<int>();
        foreach (int n in nums) {
            if (!seen.Add(n)) return true;
        }
        return false;
    }
}