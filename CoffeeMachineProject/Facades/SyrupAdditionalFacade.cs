namespace CoffeeMachineProject;

public class SyrupAdditionalFacade: IAdditionalFacade
{
    public void AddAdditional(Order order)
    {
        order.Coffee.CoffeeIngredient.Syrup += CoffeeIngredientFacade.BaseSyrup;
        Console.WriteLine("Syrup added");
    }
}