namespace CoffeeMachineProject;

public class Account
{
    public double Balance { get; set; }

    public void Deposit(double amount)
    {
        Balance += amount;
    }

    public void Withdraw(double amount)
    {
        Balance -= amount;
    }
}