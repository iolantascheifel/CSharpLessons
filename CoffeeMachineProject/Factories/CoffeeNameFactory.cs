using CoffeeMachineProject.Enums;

namespace CoffeeMachineProject;

public static class CoffeeNameFactory
{
    public static string CreateCoffeeName(CoffeeType coffeeType, CoffeeSize coffeeSize)
    {
        return coffeeType == CoffeeType.Espresso 
            ? $"Эспрессо {coffeeSize.ToString()}"
            : coffeeType == CoffeeType.Latte
                ? $"Латте {coffeeSize.ToString()}"
                : $"Капучино {coffeeSize.ToString()}";
    }
}