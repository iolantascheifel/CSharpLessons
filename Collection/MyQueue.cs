using System.Collections;

namespace Collection;

public class MyQueue<T> : IMyQueue<T>
{
    private Node<T>? _head;
    private Node<T>? _tail;

    public void Enqueue(T item)
    {
        Node<T> newNode = new Node<T> { Data = item, Next = null };

        if (_head == null)
        {
            _head = newNode;
            _tail = newNode;
        }
        else
        {
            _tail!.Next = newNode;
            _tail = newNode;
        }
    }

    public T? Dequeue()
    {
        if (_head == null)
        {
            return default;
        }

        Node<T> currentItem = _head;
        _head = _head.Next;
        if (_head == null)
        {
            _tail = null; // Если очередь пуста, очищаем хвост
        }
        return currentItem.Data;
    }

    // public T? Peek()
    // {
    //     return _head == null ? default : _head.Data;
    // }

    // public IEnumerator<T> GetEnumerator()
    // {
    //     Node<T>? currentItem = _head;
    //     while (currentItem != null)
    //     {
    //         yield return currentItem.Data;
    //         currentItem = currentItem.Next;
    //     }
    // }
    
    public IEnumerator<T> GetEnumerator()
    {
        return new NodeIterator<T>(_head!);
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }
}