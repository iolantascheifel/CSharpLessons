namespace Generics.DocumentChain;

public interface ICheckDocumentHandler<T> where T: class
{
    ICheckDocumentHandler<T>? Successor { get; set; }

    void Handle(T request);
}