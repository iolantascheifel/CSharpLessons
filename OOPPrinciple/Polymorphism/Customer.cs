namespace OOPPrinciple.Polymorphism;

public abstract class Customer
{
    public decimal BonusPoints { get; protected set; }

    public abstract void AddPurchase(decimal amount);

    public override string ToString()
    {
        return $"{this.GetType().Name}: BonusPoints = {BonusPoints}";
    }
}