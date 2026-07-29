public class Solution {
    public int CalPoints(string[] operations) {

        int result = 0;

        Stack<int> pointStack = new();

        foreach (string s in operations) {

            int x;

            if (int.TryParse(s, out x)) {
                pointStack.Push(x);
            } else if (s == "C" && pointStack.Count > 0) {
                pointStack.Pop();
            } else if (s == "D" && pointStack.Count > 0) {
                pointStack.Push(pointStack.Peek() * 2);
            } else if (s == "+" && pointStack.Count > 1) {
                int a = pointStack.Pop();
                int b = pointStack.Peek();
                pointStack.Push(a);
                pointStack.Push(a+b);
            }

        }

        while (pointStack.Count > 0) {
            result += pointStack.Pop();
        }

        return result;
        
    }
}