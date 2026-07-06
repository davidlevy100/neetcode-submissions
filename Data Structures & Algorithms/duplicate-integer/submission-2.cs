public class Solution {

    HashSet<int> seen = new HashSet<int>();

    public bool hasDuplicate(int[] nums) {

        foreach(int num in nums) 
        {
            if (seen.Contains(num)) {
                return true;
            } else {
                seen.Add(num);
            }
        }
        return false;
    }
}