namespace OOPPrinciple.Polymorphism;

public class RegularCustomer: Customer
{
    public override void AddPurchase(decimal amount)
    {
        BonusPoints += amount * 0.01m; // 1%
    }
}