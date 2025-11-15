using CoffeeMachineProject.Enums;

namespace CoffeeMachineProject;

public class CoffeeOrderFacade: ICoffeeOrderFacade
{
    private ICoffeeIngredientFacade _storage;
    private IAccount _account;
    
    public CoffeeOrderFacade(ICoffeeIngredientFacade coffeeIngredientStorage, IAccount account)
    {
        _storage = coffeeIngredientStorage;
        _account = account;
    }
    
    public Coffee? PrepareCoffee(Order? order)
    {
        if (order == null)
        {
            return null;
        }
        
        CoffeeIngredient ingredientsNeeded = order.Coffee.CoffeeIngredient;

        if (!_storage.HasIngredients(ingredientsNeeded))
        {
            Console.WriteLine($"Not enough ingredients for order");
            order.OrderStatus = OrderStatus.Cancelled;
            return null;
        } 

        _storage.UseIngredients(ingredientsNeeded);
        order.OrderStatus = OrderStatus.InProgress;
        _account.Deposit(order.Deposit);
        
        Console.WriteLine($"Coffee '{order.Coffee.Name}' done.");
        order.OrderStatus = OrderStatus.Completed;
        
        return order.Coffee;
    }
}