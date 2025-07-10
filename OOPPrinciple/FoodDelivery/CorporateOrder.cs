namespace OOPPrinciple.Доставка_еды;

public class CorporateOrder: StandardOrder
{
    private readonly decimal discountRate;
    
    public CorporateOrder(string[] itemNames, decimal baseCost, decimal discountRate = 0.1m)
        : base(itemNames, baseCost)
    {
        this.discountRate = discountRate;
    }

    public override decimal CalculateTotalCost()
    {
        var total = base.CalculateTotalCost();
        return total * (1 - discountRate);
    }

    public override string GetStatus()
    {
        return "Ожидает утверждения";
    }
        
}