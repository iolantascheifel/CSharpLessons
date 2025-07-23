namespace CoffeeMachineProject;

public class WaterAdditionalPriceFacade: IAdditionalPriceFacade
{
    public void UpdatePrice(Order order)
    { 
        order.Price += CoffeePriceFacade.WaterPrice;
    }
}