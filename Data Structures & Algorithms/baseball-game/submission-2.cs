public class Solution {
    public int CalPoints(string[] operations) {

        int result = 0;

        Stack<int> pointStack = new();

        foreach (string s in operations) {

            int x;

            if (int.TryParse(s, out x)) {
                pointStack.Push(x);
                result += x;
            } else if (s == "C" && pointStack.Count > 0) {
                result -= pointStack.Pop();
            } else if (s == "D" && pointStack.Count > 0) {
                int val = pointStack.Peek() * 2;
                pointStack.Push(val);
                result += val;
            } else if (s == "+" && pointStack.Count > 1) {
                int a = pointStack.Pop();
                int b = pointStack.Peek();
                pointStack.Push(a);
                pointStack.Push(a+b);
                result += a + b;
            }

        }

        return result;
        
    }
}