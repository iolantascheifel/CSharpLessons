using CoffeeMachineProject.Enums;

namespace CoffeeMachineProject;

public class CoffeeMachine: ICoffeeMachine
{
    List<Order> _orders = new List<Order>();

    private CoffeeIngredientStorage storage;

    private Account account;
    
    // private storage
    // private account
    
    public int SelectCoffee(CoffeeType coffeeType, CoffeeSize coffeeSize)
    {
        string coffeeName = coffeeType == CoffeeType.Espresso 
            ? $"Эспрессо {coffeeSize.ToString()}"
            : coffeeType == CoffeeType.Latte
                ? $"Латте {coffeeSize.ToString()}"
                : $"Капучино {coffeeSize.ToString()}";
        CoffeeIngredient coffeeIngredient = new CoffeeIngredient();
        switch (coffeeType)
        {
            case CoffeeType.Espresso:
                coffeeIngredient.CoffeeBeans = 8;
                coffeeIngredient.Water = 50;
                break;
            case CoffeeType.Latte:
                coffeeIngredient.CoffeeBeans = 8;
                coffeeIngredient.Milk = 200;
                break;
            case CoffeeType.Cappuccino:
                coffeeIngredient.CoffeeBeans = 8;
                coffeeIngredient.Milk = 100;
                coffeeIngredient.Water = 50;
                break;
        }
        
        double coefficient = (double)coffeeSize / (double)CoffeeSize.S;

        coffeeIngredient.CoffeeBeans *= coefficient;
        coffeeIngredient.Water *= coefficient;
        coffeeIngredient.Milk *= coefficient;
        coffeeIngredient.Sugar *= coefficient;

        double price = 10.0 * coffeeIngredient.CoffeeBeans / 8.0
                       + 5.0 * coffeeIngredient.Water / 50.0
                       + 20.0 * coffeeIngredient.Milk / 100.0
                       + 5.0 * coffeeIngredient.Sugar / 5.0;

        Coffee coffee = new Coffee()
        {
            Name = coffeeName,
            CoffeeIngredient = coffeeIngredient,
            CoffeeSize = coffeeSize,
            CoffeeType = coffeeType,
        };

        Order order = new Order()
        {
            Coffee = coffee,
            OrderStatus = OrderStatus.Created,
            Price = price,
            OrderNumber = OrderNumberCounter.Current++,
        };
        _orders.Add(order);

        return order.OrderNumber;
    }
    
    /*
       зерна - 8 гм 
       вода - 50мл
       молоко - 100мл
       Сахар - 5 мг
       
       Цены(за 200 мл):
       зерна - 10.0
       Вода - 5.0
       Молоко - 20.0
       Сахар - 5.0
       
       Эспрессо: 1зерно + 1вода
       Капуччино: 1зерно + 1вода + 1молоко
       Латте: 1зерно + 2молоко
     */

    public void AddDeposit(int orderNumber, double amount)
    {
        Order order = new Order();
        
        order.Deposit += amount;

        if (order.Deposit >= order.Price)
        {
            order.OrderStatus = OrderStatus.Created;
        }

        if (order.Deposit < order.Price)
        {
            Console.WriteLine("Не достаточно средств.");
        }
    }

    public void AddWater(int orderNumber)
    {
        throw new NotImplementedException();
    }

    public void AddMilk(int orderNumber)
    {
        throw new NotImplementedException();
    }

    public void AddCoffeeBeans(int orderNumber)
    {
        throw new NotImplementedException();
    }

    public void AddSugar(int orderNumber)
    {
        throw new NotImplementedException();
    }

    public Coffee PrepareCoffee(int orderNumber)
    {
        throw new NotImplementedException();
    }

    public double GiveChange(int orderNumber)
    {
        throw new NotImplementedException();
    }
}