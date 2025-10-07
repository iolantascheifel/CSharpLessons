namespace Collection;

public class Librarian: IIterator<Book>
{
    private IAggregator<Book> _aggregator;

    private int _current = -1;

    public Librarian(IAggregator<Book> aggregator)
    {
        _aggregator = aggregator;
    }

    public bool Next()
    {
        if (_current + 1 >= _aggregator.Count)
        {
            Reset();
            return false;
        }
        _current++;
        return true;
    }

    public Book Current
    {
        get
        {
            return _aggregator[_current];
        }
    }

    public void Reset()
    {
        _current = 0;
    }
}