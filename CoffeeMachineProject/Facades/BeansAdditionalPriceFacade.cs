namespace CoffeeMachineProject;

public class BeansAdditionalPriceFacade: IAdditionalPriceFacade
{
    public void UpdatePrice(Order order)
    {
        order.Price += CoffeePriceFacade.BeansPrice;
    }
}