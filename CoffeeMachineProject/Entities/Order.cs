using CoffeeMachineProject.Enums;

namespace CoffeeMachineProject;

public class Order
{
    public int OrderNumber { get; set; }
    public Coffee Coffee { get; set; }
    public double Price { get; set; }
    public OrderStatus OrderStatus { get; set; }
    public double Deposit { get; set; }
}