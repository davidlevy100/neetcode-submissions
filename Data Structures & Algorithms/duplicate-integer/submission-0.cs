public class Solution {
    public bool hasDuplicate(int[] nums) {

        bool result = false;

        HashSet<int> numCounts = new HashSet<int>();

        foreach (int i in nums) {
            if (numCounts.Contains(i)) {
                result = true;
                break;
            }
            numCounts.Add(i);
        }

        return result;

    }
}
