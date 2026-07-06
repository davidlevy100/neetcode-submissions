public class Solution {
    public bool hasDuplicate(int[] nums) {
        // `var` = compiler infers the type from the right-hand side (here HashSet<int>).
        // HashSet<T> is .NET's hash set: O(1) average Add/Contains, no duplicates.
        var seen = new HashSet<int>();

        // foreach is C#'s iterator loop; works on anything implementing IEnumerable<T>.
        foreach (int i in nums)
        {
            // C# idiom: HashSet.Add returns bool — false if the item was ALREADY present.
            // So a false return == we've seen this value before == duplicate. One lookup, not two.
            if (!seen.Add(i)) return true;
        }

        return false;
    }
}