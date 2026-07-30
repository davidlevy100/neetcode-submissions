public class MinStack {

    private Stack<(int, int)> _stack;

    public MinStack() {
        _stack = new();
    }
    
    public void Push(int val) {
        if (_stack.Count == 0) {
            _stack.Push((val, val));
        } else {
            (int _, int lastMin) = _stack.Peek();
            _stack.Push((val, Math.Min(val, lastMin)));
        }
    }
    
    public void Pop() {
        _stack.Pop();
    }
    
    public int Top() {
        (int n, int _) = _stack.Peek();
        return n;
    }
    
    public int GetMin() {
        (int _, int n) = _stack.Peek();
        return n;
    }
}
