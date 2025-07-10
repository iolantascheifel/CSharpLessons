namespace OOPPrinciple.Polymorphism;

public class VIPCustomer : Customer
{
    public override void AddPurchase(decimal amount)
    {
        BonusPoints += amount * 0.10m; // 10%
    }
}