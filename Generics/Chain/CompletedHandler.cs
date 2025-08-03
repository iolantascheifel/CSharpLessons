namespace Generics.Chain;

public class CompletedHandler: IHandler<Product>
{
    public IHandler<Product>? Successor { get; set; }
    public Product Handle(Product request)
    {
       return request;
    }
}