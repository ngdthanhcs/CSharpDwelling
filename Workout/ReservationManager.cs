namespace Workout;

public class SeatManager
{
    public SeatManager(int n) {}

    public int Reserve() {
        if (_minHeap.Count == 0)
            return ++_num;
        return _minHeap.Dequeue();
    }

    public void Unreserve(int seatNumber) {
        _minHeap.Enqueue(seatNumber, seatNumber);
    }

    private readonly PriorityQueue<int, int> _minHeap = new();
    private int _num;
}