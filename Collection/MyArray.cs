using System.Collections;

namespace Collection;

public class MyArray<T>: IMyArrayList<T>
{
    private T[] _array = new T[4];

    private int _current = 0;
    public IEnumerator<T> GetEnumerator()
    {
        for (int i = 0; i < _current; i++)
        {
            yield return _array[i];
        }
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }

    public T this[int index]
    {
        get => _array[index];
        set => _array[index] = value;
    }

    public int IndexOf(T item)
    {
        for (int i = 0; i < _current; i++)
        {
            if (_array[i] != null && _array[i]!.Equals(item))
            {
                return i;
            }
        }
        return -1;
    }

    public void Add(T item)
    {
        if (_current >= _array.Length)
        {
            Resize(_array.Length * 2);
        }
        _array[_current] = item;
        _current++;
    }

    public void Clear()
    {
        _array = new T[4];
        _current = 0;
    }

    public void Remove(T item)
    {
        int index = IndexOf(item);
        if (index == -1)
        {
            return;
        }

        if (_array.Length == 1)
        {
            Clear();
            return;
        }
     
        if (index != _current - 1)
        {
            for (int i = index; i < _current - 2; i++)
            {
                _array[i] = _array[i + 1];
            }
        }
        _array[_current - 1] = default!;
        _current--;
        if (_current < _array.Length / 2)
        {
            Resize(_array.Length / 2);
        }
    }

    public bool Contains(T item)
    {
        return IndexOf(item) != -1;
    }

    private void Resize(int newSize)
    {
        T[] newArray = new T[newSize];
        Array.Copy(_array, newArray, _array.Length);
        _array = newArray;
    }
}