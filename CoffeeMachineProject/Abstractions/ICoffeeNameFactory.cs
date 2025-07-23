using CoffeeMachineProject.Enums;

namespace CoffeeMachineProject;

public interface ICoffeeNameFactory
{
    string CreateCoffeeName(CoffeeType coffeeType, CoffeeSize coffeeSize);
}