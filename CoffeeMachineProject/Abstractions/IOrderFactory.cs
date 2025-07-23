using CoffeeMachineProject.Enums;

namespace CoffeeMachineProject;

public interface IOrderFactory
{
    Order CreateOrder(CoffeeType coffeeType, CoffeeSize coffeeSize);
}