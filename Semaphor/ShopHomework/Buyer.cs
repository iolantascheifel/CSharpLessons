namespace Semaphor.ShopHomework;

public class Buyer
{
    public int Id { get; }

    private Dictionary<Product, BuyerStatus> Statuses { get; }

    public Buyer(int id)
    {
        Id = id;
        Statuses = new Dictionary<Product, BuyerStatus>();
    }

    private void Browsing(Product product)
    {
        Statuses[product] = BuyerStatus.Browsing;
        Console.WriteLine($"Buyer {Id} browsing {product.Name}.");
        Thread.Sleep(2000);
    }

    public void Buying(Product product)
    {
        Browsing(product);
        Statuses[product] = BuyerStatus.CollectingStuff;
        Console.WriteLine($"Buyer {Id} collecting {product.Name} into the basket.");
        Thread.Sleep(2000);
        Statuses[product] = BuyerStatus.StandingInLine;
        Console.WriteLine($"Buyer {Id} standing in line to the cashier.");
        Thread.Sleep(2000);
        product.Cashier.CashierServing(product, this);
        Statuses[product] = BuyerStatus.Paying;
        Console.WriteLine($"Buyer {Id} paying {product.Name}.");
    }
}