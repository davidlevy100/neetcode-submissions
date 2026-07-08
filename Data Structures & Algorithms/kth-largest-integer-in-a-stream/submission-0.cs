public class KthLargest
{
    // PriorityQueue<TElement, TPriority> is a min-heap: lowest priority dequeues first
    // Using <int, int> because element and priority are the same value
    private readonly PriorityQueue<int, int> _pq = new();
    private readonly int _k;

    public KthLargest(int k, int[] nums)
    {
        _k = k;
        Enqueue(nums);
    }

    public int Add(int val)
    {
        Enqueue(val);

        // Root of a size-k min-heap = the smallest of the k largest = k-th largest
        return _pq.Peek();
    }

    // Enqueue + trim: keeps the heap at size k by evicting the smallest
    private void Enqueue(int num)
    {
        _pq.Enqueue(num, num);

        if (_pq.Count > _k)
        {
            _pq.Dequeue();
        }
    }

    private void Enqueue(int[] nums)
    {
        foreach (int n in nums)
        {
            Enqueue(n);
        }
    }

}
