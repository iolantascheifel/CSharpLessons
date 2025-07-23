namespace CoffeeMachineProject;

public class MilkAdditionalPriceFacade: IAdditionalPriceFacade
{
    public void UpdatePrice(Order order)
    {
        order.Price += CoffeePriceFacade.MilkPrice;
    }
}