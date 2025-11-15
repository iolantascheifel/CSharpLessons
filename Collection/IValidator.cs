namespace Collection;

public interface IValidator<in T>
{
    bool IsValid(T entity);
}