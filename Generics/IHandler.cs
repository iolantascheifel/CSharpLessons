namespace Generics;

public interface IHandler<T>
{
    IHandler<T>? Successor { get; set; }

    T Handle(T request);

}