public class MinStack
{
    private List<int> _list = new List<int>();
    private List<int> _mins = new List<int>();

    public MinStack() {
    }

    public void Push(int val) {
        _list.Add(val);
        if (_mins.Count == 0 || val <= _mins[_mins.Count - 1]) {
            _mins.Add(val);
        } else {
            _mins.Add(_mins[_mins.Count - 1]);
        }
    }

    public void Pop() {
        if (_list.Count > 0) {
            _list.RemoveAt(_list.Count - 1);
            _mins.RemoveAt(_mins.Count - 1);
        }
    }

    public int Top() {
        return _list[_list.Count - 1];
    }

    public int GetMin() {
        return _mins[_mins.Count - 1];
    }
}