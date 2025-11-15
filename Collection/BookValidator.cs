namespace Collection;

public class BookValidator: IValidator<Book>
{
    public bool IsValid(Book entity)
    {
        if (string.IsNullOrEmpty(entity.Name) || string.IsNullOrEmpty(entity.Author))
        {
            return false;
        }

        if (entity.Author.Length < 2 || entity.Name.Length < 2)
        {
            return false;
        }

        if (entity.PageCount < 1)
        {
            return false;
        }

        foreach (var symbol in entity.Author)
        {
            if (char.IsDigit(symbol))
            {
                return false;
            }
        }
        return true;
    }
}