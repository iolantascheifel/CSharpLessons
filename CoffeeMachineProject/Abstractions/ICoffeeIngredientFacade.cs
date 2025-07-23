using CoffeeMachineProject.Enums;

namespace CoffeeMachineProject;

public interface ICoffeeIngredientFacade
{
    CoffeeIngredient GetLatteIngredient();

    CoffeeIngredient GetEspressoIngredient();

    CoffeeIngredient GetCappuccinoIngredient();

    void UpdateIngredientsByCoffeeSize(CoffeeIngredient coffeeIngredient, CoffeeSize coffeeSize);
    
    IAdditionalFacade GetMilkAdditionalFacade();
    IAdditionalFacade GetWaterAdditionalFacade();
    IAdditionalFacade GetBeansAdditionalFacade();
    IAdditionalFacade GetSugarAdditionalFacade();
}