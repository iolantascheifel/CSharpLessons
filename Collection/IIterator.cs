namespace Collection;

public interface IIterator<T>
{
    bool Next();
    T Current { get; }
    void Reset();
}