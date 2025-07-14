using CoffeeMachineProject.Enums;

namespace CoffeeMachineProject;

public interface ICoffeeMachine
{
    int SelectCoffee(CoffeeType  coffeeType, CoffeeSize coffeeSize);
    void AddDeposit(int orderNumber, double amount);
    void AddWater(int orderNumber);
    void AddMilk(int orderNumber);
    void AddCoffeeBeans(int orderNumber);
    void AddSugar(int orderNumber);
    Coffee PrepareCoffee(int orderNumber);
    double GiveChange(int orderNumber);
}