public class MinStack {

    private Stack<(int Value, int Min)> _stack;

    public MinStack() => _stack = new();
    
    public void Push(int val) => 
        _stack.Push((
            val, _stack.Count == 0 
            ? val 
            : Math.Min(val, _stack.Peek().Min
        )));
    
    public void Pop() => _stack.Pop();
    
    public int Top() => _stack.Peek().Value;
    
    public int GetMin() => _stack.Peek().Min;
}
