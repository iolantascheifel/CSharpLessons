namespace Collection;

public class Book: Text
{
    public int PageCount { get; set; }

    public override string ToString()
    {
        return $"{Author} - {Name},  Page Count: {PageCount}";
    }
}