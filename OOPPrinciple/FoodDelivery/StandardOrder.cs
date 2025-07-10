namespace OOPPrinciple.Доставка_еды;

public class StandardOrder: Order
{
    private const decimal DeliveryFee = 200;
    public StandardOrder(string[] itemNames, decimal baseCost)
        : base(itemNames, baseCost)
    {
    }
    
    public override decimal CalculateTotalCost()
    {
        return baseCost + DeliveryFee;
    }

}