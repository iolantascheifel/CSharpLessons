namespace CoffeeMachineProject;

public class CoffeeIngredientStorage: ICoffeeIngredientStorage
{
    private const double MaxWaterVolume = 5000;
    private const double MaxMilkVolume = 5000;
    private const double MaxSugarVolume = 5000;
    private const double MaxCoffeeBeansVolume = 5000;
    private const double MaxSyrupVolume = 5000;

    private readonly CoffeeIngredient _coffeeIngredient = new CoffeeIngredient() 
    {
        CoffeeBeans = MaxCoffeeBeansVolume,
        Water = MaxWaterVolume,
        Milk = MaxMilkVolume,
        Sugar = MaxSugarVolume,
        Syrup = MaxSyrupVolume,
    };
    
    public bool HasIngredients(CoffeeIngredient coffeeIngredient)
    {
        if (_coffeeIngredient.CoffeeBeans < coffeeIngredient.CoffeeBeans)
        {
            Console.WriteLine("Not enough beans");
            return false;
        }

        if (_coffeeIngredient.Water < coffeeIngredient.Water)
        {
            Console.WriteLine("Not enough water");
            return false;
        }

        if (_coffeeIngredient.Milk < coffeeIngredient.Milk)
        {
            Console.WriteLine("Not enough milk");
            return false;
        }

        if (_coffeeIngredient.Sugar < coffeeIngredient.Sugar)
        {
            Console.WriteLine("Not enough sugar");
            return false;
        }
        
        if (_coffeeIngredient.Syrup < coffeeIngredient.Syrup)
        {
            Console.WriteLine("Not enough syrup");
            return false;
        }
        return true;
    }

    public void UseIngredients(CoffeeIngredient ingredient)
    {
        if (!HasIngredients(ingredient))
        {
           AddIngredients();
        }
        _coffeeIngredient.CoffeeBeans -= ingredient.CoffeeBeans;
        _coffeeIngredient.Water -= ingredient.Water;
        _coffeeIngredient.Milk -= ingredient.Milk;
        _coffeeIngredient.Sugar -= ingredient.Sugar;
        _coffeeIngredient.Syrup -= ingredient.Syrup;
    }

    public void AddIngredients()
    {
        _coffeeIngredient.CoffeeBeans = MaxCoffeeBeansVolume;
        _coffeeIngredient.Water = MaxWaterVolume;
        _coffeeIngredient.Milk = MaxMilkVolume;
        _coffeeIngredient.Sugar = MaxSugarVolume;
        _coffeeIngredient.Syrup = MaxSyrupVolume;
    }
}