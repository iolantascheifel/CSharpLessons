namespace Collection;

public interface IMyStack<T>: IEnumerable<T>
{
    void Push(T item);
    T? Pop();
    T? Peek();
}