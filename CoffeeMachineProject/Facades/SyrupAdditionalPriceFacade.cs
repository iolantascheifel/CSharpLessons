namespace CoffeeMachineProject;

public class SyrupAdditionalPriceFacade: IAdditionalPriceFacade
{
    public void UpdatePrice(Order order)
    {
        order.Price += CoffeePriceFacade.SyrupPrice;
    }
}