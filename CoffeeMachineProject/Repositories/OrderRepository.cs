namespace CoffeeMachineProject;

public class OrderRepository: IOrderRepository
{
    List<Order> _orders = new List<Order>();
    
    public int AddOrder(Order order)
    {
        _orders.Add(order);
        
        return order.OrderNumber;
    }

    public Order? GetOrder(int orderNumber)
    {
        Order? order = null;
        foreach (var o in _orders)
        {
            if (o.OrderNumber == orderNumber)
            {
                order = o;
                break;
            }
        }

        if (order == null)
        {
            Console.WriteLine("Order not found");
        }
        return order;
    }
}