using System.Collections;

namespace Collection;

public class NodeIterator<T> : IEnumerator<T>
{
    private Node<T> _current;
    private Node<T> _head;
    private bool isFirst = true;

    public NodeIterator(Node<T> head)
    {
        _head = head;
        _current = head;
    }

    public bool MoveNext()
    {
        if (isFirst)
        {
            isFirst = false;
            return true;
        }

        if (_current.Next != null)
        {
            _current = _current.Next;
            return true;
        }
        Reset();
        return false;
    }

    public void Reset()
    {
        isFirst = true;
        _current = _head;
    }

    T IEnumerator<T>.Current => _current.Data;

    object? IEnumerator.Current => _current.Data;

    public void Dispose()
    {
    }
}