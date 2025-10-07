namespace Collection;

public interface IAggregator<T>
{
    IIterator<T> CreateIterator();
    T this[int i] { get; }
    
    int Count { get; }
}