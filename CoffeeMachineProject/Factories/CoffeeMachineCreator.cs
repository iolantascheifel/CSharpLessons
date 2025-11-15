namespace CoffeeMachineProject;

public static class CoffeeMachineCreator
{
    public static CoffeeMachine CreateCoffeeMachine()
    {
        Account account = new Account();
        return new CoffeeMachine(account);
    }
}