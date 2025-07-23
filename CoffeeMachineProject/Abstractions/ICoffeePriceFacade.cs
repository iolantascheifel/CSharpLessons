namespace CoffeeMachineProject;

public interface ICoffeePriceFacade
{
    double GetPrice(CoffeeIngredient coffeeIngredient);


    IAdditionalPriceFacade GetMilkAdditionalPriceFacade();
    
    IAdditionalPriceFacade GetSugarAdditionalPriceFacade();
    
    IAdditionalPriceFacade GetWaterAdditionalPriceFacade();
    
    IAdditionalPriceFacade GetBeansAdditionalPriceFacade();

}