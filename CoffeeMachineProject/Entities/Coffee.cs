using CoffeeMachineProject.Enums;

namespace CoffeeMachineProject;

public class Coffee
{
    public string Name { get; set; }
    public CoffeeType CoffeeType { get; set; }
    public CoffeeSize CoffeeSize { get; set; }
    public CoffeeIngredient CoffeeIngredient { get; set; }
}