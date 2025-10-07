namespace Collection;

public class Library: IAggregator<Book>
{
    private List<Book> _books = new List<Book>();

    public Library(List<Book> books)
    {
        _books.AddRange(books);
    }
    
    public IIterator<Book> CreateIterator()
    {
        return new Librarian(this);
    }

    public Book this[int i] //индексатор
    {
        get { return _books[i]; }
    }

    public int Count
    {
        get
        {
            return _books.Count;
        }
    }

    // The same method
    // public Book GetByIndex(int i)
    // {
    //     return _books[i];
    // }
}