namespace Collection;

public class BookComparer: IComparer<Book>
{
    public int Compare(Book? x, Book? y)
    {
        if (ReferenceEquals(x, y)) return 0;
        if (y is null) return 1;
        if (x is null) return -1;
        var authorComparison = string.Compare(x.Author, y.Author, StringComparison.Ordinal);
        if (authorComparison != 0) return authorComparison;
        return string.Compare(x.Name, y.Name, StringComparison.Ordinal);
    }
}