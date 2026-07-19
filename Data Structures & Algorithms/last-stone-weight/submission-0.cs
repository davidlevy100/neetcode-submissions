public class Solution {
    public int LastStoneWeight(int[] stones)
    {
        // Negate priority to simulate a max-heap (PriorityQueue is min-heap only)
        PriorityQueue<int, int> pq = new();

        foreach (int n in stones)
        {
            pq.Enqueue(n, -n);
        }

        // Each iteration smashes the two heaviest stones
        while (pq.Count > 1)
        {
            int a = pq.Dequeue();
            int b = pq.Dequeue();

            // a >= b guaranteed by max-heap ordering, so no Math.Abs needed
            int c = a - b;

            if (c > 0) pq.Enqueue(c, -c);
        }

        // Either one stone remains or all cancelled out
        return pq.Count == 1 ? pq.Dequeue() : 0;
    }
}
