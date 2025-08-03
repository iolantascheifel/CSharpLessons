namespace Generics.Chain;

public class ProductStorageHandler: IHandler<Product>
{
    public IHandler<Product>? Successor { get; set; }
    private List<Product> _storage;

    public ProductStorageHandler(List<Product> storage)
    {
        _storage = storage;
    }
    
    public Product Handle(Product request)
    {
        foreach (var product in _storage)
        {
            if (product.Name == request.Name)
            {
                request.Price = product.Price;
                if (Successor == null)
                {
                    throw new Exception("Requirements handler not found");
                }

                return Successor.Handle(request);
            }
        }
        throw new Exception("Product not found");
    }
}

///requirement document info with passport and etc.
/// handlers to check each document
/// 