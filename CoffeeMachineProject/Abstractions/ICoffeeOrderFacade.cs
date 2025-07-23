namespace CoffeeMachineProject;

public interface ICoffeeOrderFacade
{
    Coffee? PrepareCoffee(Order? order );
}