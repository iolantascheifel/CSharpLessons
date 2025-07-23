namespace CoffeeMachineProject;

public static class CoffeeMachineCreator
{
    public static CoffeeMachine CreateCoffeeMachine()
    {
        CoffeeIngredientStorage coffeeIngredientStorage = new CoffeeIngredientStorage();
        Account account = new Account();
        return new CoffeeMachine(coffeeIngredientStorage, account);
    }
}