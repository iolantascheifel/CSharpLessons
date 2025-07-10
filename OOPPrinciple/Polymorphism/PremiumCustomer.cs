namespace OOPPrinciple.Polymorphism;

public class PremiumCustomer: Customer
{
    public override void AddPurchase(decimal amount)
    {
        BonusPoints += amount * 0.05m; // 5%
    }
}