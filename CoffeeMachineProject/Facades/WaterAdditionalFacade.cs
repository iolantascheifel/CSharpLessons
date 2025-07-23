namespace CoffeeMachineProject;

public class WaterAdditionalFacade: IAdditionalFacade
{
    public void AddAdditional(Order order)
    {
        order.Coffee.CoffeeIngredient.Water += CoffeeIngredientFacade.BaseWater;
        Console.WriteLine("Water added");
    }
}