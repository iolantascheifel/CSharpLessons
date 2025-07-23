namespace CoffeeMachineProject;

public class Account: IAccount
{
    public double Balance { get; private set; }

    public void Deposit(double amount)
    {
        Balance += amount;
    }

    public void Withdraw(double amount)
    {
        Balance -= amount;
    }
}