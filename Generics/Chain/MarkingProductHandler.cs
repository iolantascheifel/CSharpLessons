namespace Generics.Chain;

public class MarkingProductHandler: IHandler<Product>
{
    public IHandler<Product>? Successor { get; set; }
    public Product Handle(Product request)
    {
       request.Id = Guid.NewGuid();
       if (Successor == null)
       {
           throw new Exception("Requirements handler not found");
       }
       return Successor.Handle(request);
    }
}