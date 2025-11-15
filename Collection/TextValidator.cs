namespace Collection;

public class TextValidator: IValidator<Text>
{
    public bool IsValid(Text entity)
    {
        if (string.IsNullOrEmpty(entity.Name) || string.IsNullOrEmpty(entity.Author))
        {
            return false;
        }

        if (entity.Author.Length < 2 || entity.Name.Length < 2)
        {
            return false;
        }
        return true;
    }
}