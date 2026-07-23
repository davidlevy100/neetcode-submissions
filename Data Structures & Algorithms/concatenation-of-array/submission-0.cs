public class Solution {
    public int[] GetConcatenation(int[] nums)
    {
        // Result is twice the input length — nums repeated back-to-back
        int[] result = new int[nums.Length * 2];

        // i % nums.Length wraps the index: 0..n-1 maps to first copy, n..2n-1 wraps back to 0..n-1 for second copy
        for (int i = 0; i < result.Length; i++)
        {
            result[i] = nums[i % nums.Length];
        }

        // Idiomatic alternatives:
        //   Array.Copy(nums, 0, result, 0, n); Array.Copy(nums, 0, result, n, n);  — bulk memcpy, fastest
        //   nums.Concat(nums).ToArray();        — LINQ, readable but allocates intermediate sequence
        //   [..nums, ..nums];                   — C# 12 collection expression spread, shortest form

        return result;
    }
}