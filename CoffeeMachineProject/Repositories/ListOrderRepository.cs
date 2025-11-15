namespace CoffeeMachineProject;

public class ListOrderRepository: IRepository<int, Order>
{
    private List<Order> _orders = new List<Order>();
    
    public int Add(Order order)
    {
        _orders.Add(order);
        
        return order.OrderNumber;
    }

    public Order? Get(int orderNumber)
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

    public bool Remove(Order entity)
    {
        return _orders.Remove(entity);
    }
}