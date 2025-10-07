using System.Collections;

namespace Collection;

public class MyStack<T>: IMyStack<T>
{
    private Node<T>? _head;
    
    public void Push(T item)
    {
        Node<T> currentItem = new Node<T>()
        {
            Data = item
        };
        
        if (_head == null)
        {
            _head = currentItem;
            return;
        }
        currentItem.Next = _head;
        _head = currentItem;
    }

    public T? Pop()
    {
        if (_head == null)
        {
            return default;
        }
        Node<T> currentItem = _head;
        _head = _head.Next;
        return currentItem.Data;
    }

    public T? Peek()
    {
        return _head == null ? default : _head.Data;
    }

    public IEnumerator<T> GetEnumerator()
    {
        Node<T>? curentItem = _head;
        while (curentItem != null)
        {
            yield return curentItem.Data;
            curentItem = curentItem.Next;
        }
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }
}