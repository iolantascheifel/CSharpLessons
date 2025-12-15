namespace Semaphor.ShopHomework;

public class Cashier
{
    public string Name { get; }
    
    private readonly SemaphoreSlim _semaphoreSlim = new SemaphoreSlim(1, 1);

    public Cashier(string name)
    {
        Name = name;
    }

    public void CashierServing(Product product, Buyer buyer)
    {
        _semaphoreSlim.Wait();

        try
        {
            Console.WriteLine($"Cashier {Name} serving buyer{buyer.Id} who is buying {product.Name}.");
            Thread.Sleep(2000);
        }
        finally
        {
            _semaphoreSlim.Release();
        }
    }
}