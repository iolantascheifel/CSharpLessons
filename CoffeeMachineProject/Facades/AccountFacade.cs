using CoffeeMachineProject.Enums;

namespace CoffeeMachineProject;

public class AccountFacade: IAccountFacade
{
    private IAccount _account;

    public AccountFacade(IAccount account)
    {
        _account = account;
    }

    public double GiveChange(Order order)
    {
        double change = order.Deposit - order.Price;
        order.Deposit = 0;
        order.OrderStatus = OrderStatus.Completed;
        _account.Withdraw(change);

        Console.WriteLine($"Сдача: {change}");
        return change;
    }
}