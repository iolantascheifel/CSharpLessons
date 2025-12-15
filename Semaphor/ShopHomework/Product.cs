namespace Semaphor.ShopHomework;

public class Product
{
    public string Name { get; }
    
    public Cashier Cashier { get; }

    public Product(string name,  Cashier cashier)
    {
        Name = name;
        Cashier = cashier;
    }
}