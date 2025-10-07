namespace Collection;

public interface IMyArrayList<T> : IEnumerable<T>
{
    T this[int index]  { get; set; }
    
    int IndexOf(T item);

    void Add(T item);
    
    void Clear();

    void Remove(T item);
    
    bool Contains(T item);
}