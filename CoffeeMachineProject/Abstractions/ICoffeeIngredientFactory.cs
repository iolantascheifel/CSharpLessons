using CoffeeMachineProject.Enums;

namespace CoffeeMachineProject;

public interface ICoffeeIngredientFactory
{
    CoffeeIngredient GetIngredientsByCoffeeType(CoffeeType coffeeType, CoffeeSize coffeeSize);
    
}