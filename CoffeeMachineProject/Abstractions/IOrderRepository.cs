namespace CoffeeMachineProject;

public interface IOrderRepository
{
    int AddOrder(Order order);
    Order? GetOrder(int orderNumber);
}