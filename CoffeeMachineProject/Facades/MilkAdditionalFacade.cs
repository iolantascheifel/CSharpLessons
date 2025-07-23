namespace CoffeeMachineProject;

public class MilkAdditionalFacade: IAdditionalFacade
{
    public void AddAdditional(Order order)
    {
       order.Coffee.CoffeeIngredient.Milk += CoffeeIngredientFacade.BaseMilk;
       Console.WriteLine("Milk added");
    }
}