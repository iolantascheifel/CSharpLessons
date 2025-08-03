namespace Generics.DocumentChain;

public abstract class BaseHandler<T>: ICheckDocumentHandler<T> where T : class
{
    public ICheckDocumentHandler<T>? Successor { get; set; }
    public virtual void Handle(T request)
    {
        if (Successor == null)
        {
            throw new Exception("Requirements handler not found");
        }
        Successor.Handle(request);
    }
}