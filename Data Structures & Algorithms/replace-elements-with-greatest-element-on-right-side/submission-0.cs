public class Solution {
    public int[] ReplaceElements(int[] arr) {

        int rightMax = -1;

        for (int i = arr.Length-1; i >= 0; i--) {
            (arr[i], rightMax) = (rightMax, Math.Max(arr[i], rightMax)); 
        }

        return arr;
        
    }
}