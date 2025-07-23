namespace CoffeeMachineProject;

public class SugarAdditionalFacade: IAdditionalFacade
{
    public void AddAdditional(Order order)
    {
        order.Coffee.CoffeeIngredient.Sugar += CoffeeIngredientFacade.BaseSugar;
        Console.WriteLine("Sugar added");
    }
}