namespace CoffeeMachineProject;

public class SugarAdditionalPriceFacade: IAdditionalPriceFacade
{
    public void UpdatePrice(Order order)
    {
        order.Price += CoffeePriceFacade.SugarPrice;
    }
}