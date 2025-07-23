namespace CoffeeMachineProject;

public class BeansAdditionalFacade: IAdditionalFacade
{
    public void AddAdditional(Order order)
    {
        order.Coffee.CoffeeIngredient.CoffeeBeans += CoffeeIngredientFacade.BaseBeans;
        Console.WriteLine("Beans added");
    }
}