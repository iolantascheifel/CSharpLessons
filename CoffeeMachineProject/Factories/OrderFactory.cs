using CoffeeMachineProject.Enums;

namespace CoffeeMachineProject;

public class OrderFactory: IOrderFactory
{
    
    private CoffeeIngredientFactory coffeeIngredientFactory = new CoffeeIngredientFactory();
    
    private CoffeePriceFacade _coffeePriceFacade = new CoffeePriceFacade();
    
    public Order CreateOrder(CoffeeType coffeeType, CoffeeSize coffeeSize)
    {
        string coffeeName = CoffeeNameFactory.CreateCoffeeName(coffeeType, coffeeSize);
        
        CoffeeIngredient coffeeIngredient = coffeeIngredientFactory.GetIngredientsByCoffeeType(coffeeType, coffeeSize);

        double price = _coffeePriceFacade.GetPrice(coffeeIngredient);
        
        return CreateOrder(coffeeName, coffeeIngredient, coffeeSize, coffeeType, price);
    }
    
    private Order CreateOrder(string coffeeName,  CoffeeIngredient coffeeIngredient, CoffeeSize coffeeSize, 
        CoffeeType coffeeType, double price)
    {
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

        return order;
    }
    
}