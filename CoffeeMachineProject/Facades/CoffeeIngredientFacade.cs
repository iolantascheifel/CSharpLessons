using CoffeeMachineProject.Enums;

namespace CoffeeMachineProject;

public class CoffeeIngredientFacade: ICoffeeIngredientFacade
{
    public const double BaseBeans = 8.0;
    
    public  const double BaseMilk = 100.0;
    
    public const double BaseSugar = 5.0;

    public const double BaseWater = 50.0;
    
    public CoffeeIngredient GetLatteIngredient()
    {
        return new CoffeeIngredient()
        {
            CoffeeBeans = BaseBeans,
            Milk = BaseMilk * 2,
        };
    }

    public CoffeeIngredient GetEspressoIngredient()
    {
        return new CoffeeIngredient()
        {
            CoffeeBeans = BaseBeans,
            Water = BaseWater,
        };
    }

    public CoffeeIngredient GetCappuccinoIngredient()
    {
        return new CoffeeIngredient()
        {
            CoffeeBeans = BaseBeans,
            Water = BaseWater,
            Milk = BaseMilk,
        };
    }

    public void UpdateIngredientsByCoffeeSize(CoffeeIngredient coffeeIngredient, CoffeeSize coffeeSize)
    {
        double coefficient = (double)coffeeSize / (double)CoffeeSize.S;

        coffeeIngredient.CoffeeBeans *= coefficient;
        coffeeIngredient.Water *= coefficient;
        coffeeIngredient.Milk *= coefficient;
    }

    public IAdditionalFacade GetMilkAdditionalFacade()
    {
        return new MilkAdditionalFacade();
    }

    public IAdditionalFacade GetWaterAdditionalFacade()
    {
        return new WaterAdditionalFacade();
    }

    public IAdditionalFacade GetBeansAdditionalFacade()
    {
        return new BeansAdditionalFacade();
    }

    public IAdditionalFacade GetSugarAdditionalFacade()
    {
        return new SugarAdditionalFacade();
    }
}