using CoffeeMachineProject.Enums;

namespace CoffeeMachineProject;

public interface ICoffeeIngredientFacade
{
    CoffeeIngredient GetLatteIngredient();

    CoffeeIngredient GetEspressoIngredient();

    CoffeeIngredient GetCappuccinoIngredient();
    bool HasIngredients(CoffeeIngredient coffeeIngredient);
    void UseIngredients(CoffeeIngredient ingredient);

    void UpdateIngredientsByCoffeeSize(CoffeeIngredient coffeeIngredient, CoffeeSize coffeeSize);
    
    IAdditionalFacade GetMilkAdditionalFacade();
    IAdditionalFacade GetWaterAdditionalFacade();
    IAdditionalFacade GetBeansAdditionalFacade();
    IAdditionalFacade GetSugarAdditionalFacade();
    IAdditionalFacade GetSyrupAdditionalFacade();
}