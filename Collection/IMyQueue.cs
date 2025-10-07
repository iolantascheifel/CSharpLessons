namespace Collection;

public interface IMyQueue<T> : IEnumerable<T>
{
    void Enqueue(T item); // Add to end
    T? Dequeue();         // Remove from front
    // T? Peek();            // See the front
}
