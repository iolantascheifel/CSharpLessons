namespace CoffeeMachineProject;

public class CoffeePriceFacade: ICoffeePriceFacade
{
    public const double BeansPrice = 10.0;
    
    public const double MilkPrice = 20.0;
    
    public const double SugarPrice = 5.0;
    
    public const double WaterPrice = 5.0;
    
    
    public double GetPrice(CoffeeIngredient coffeeIngredient)
    {
        return BeansPrice * coffeeIngredient.CoffeeBeans / CoffeeIngredientFacade.BaseBeans
               + WaterPrice * coffeeIngredient.Water / CoffeeIngredientFacade.BaseWater
               + MilkPrice * coffeeIngredient.Milk / CoffeeIngredientFacade.BaseMilk
               + SugarPrice * coffeeIngredient.Sugar / CoffeeIngredientFacade.BaseSugar;
    }

    public IAdditionalPriceFacade GetMilkAdditionalPriceFacade()
    {
        return new  MilkAdditionalPriceFacade();
    }

    public IAdditionalPriceFacade GetSugarAdditionalPriceFacade()
    {
       return new  SugarAdditionalPriceFacade();
    }

    public IAdditionalPriceFacade GetWaterAdditionalPriceFacade()
    {
        return new  WaterAdditionalPriceFacade();
    }

    public IAdditionalPriceFacade GetBeansAdditionalPriceFacade()
    {
        return new  BeansAdditionalPriceFacade();
    }
}

