using CoffeeMachineProject.Enums;

namespace CoffeeMachineProject;

public class CoffeeIngredientFactory: ICoffeeIngredientFactory
{
    
    private CoffeeIngredientFacade _ingredientFacade = new CoffeeIngredientFacade();
    public CoffeeIngredient GetIngredientsByCoffeeType(CoffeeType coffeeType, CoffeeSize coffeeSize)
    {
        CoffeeIngredient coffeeIngredient = new CoffeeIngredient();
        switch (coffeeType)
        {
            case CoffeeType.Espresso:
                coffeeIngredient = _ingredientFacade.GetEspressoIngredient();
                break;
            case CoffeeType.Latte:
                coffeeIngredient = _ingredientFacade.GetLatteIngredient();
                break;
            case CoffeeType.Cappuccino:
                coffeeIngredient = _ingredientFacade.GetCappuccinoIngredient();
                break;
            default:
                throw new ArgumentException("This type of coffeeType is not supported.");
        }
        _ingredientFacade.UpdateIngredientsByCoffeeSize(coffeeIngredient, coffeeSize);
        return coffeeIngredient;
    }
    
}