namespace Generics.DocumentChain;

public class BaseBuilder<T> where T : class
{
    private readonly ICheckDocumentHandler<T> _first;
    private ICheckDocumentHandler<T> _current;

    public BaseBuilder(ICheckDocumentHandler<T> first)
    {
        _first = first;
        _current = _first;
    }

    public BaseBuilder<T> AddHandler(ICheckDocumentHandler<T> handler)
    {
        _current.Successor = handler;
        _current = handler;
        return this;
    }

    public ICheckDocumentHandler<T> Build()
    {
        return _first;
    }
}