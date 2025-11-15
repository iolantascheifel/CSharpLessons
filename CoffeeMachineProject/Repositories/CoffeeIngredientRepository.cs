namespace CoffeeMachineProject;

public class CoffeeIngredientRepository: IRepository<Unit, CoffeeIngredient>
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
    
    public Unit Add(CoffeeIngredient entity)
    {
        _coffeeIngredient.CoffeeBeans = MaxCoffeeBeansVolume;
        _coffeeIngredient.Water = MaxWaterVolume;
        _coffeeIngredient.Milk = MaxMilkVolume;
        _coffeeIngredient.Sugar = MaxSugarVolume;
        _coffeeIngredient.Syrup = MaxSyrupVolume;

        return new Unit();
    }

    public CoffeeIngredient? Get(Unit id)
    {
        CoffeeIngredient? coffeeIngredient = new CoffeeIngredient()
        {
            CoffeeBeans = _coffeeIngredient.CoffeeBeans,
            Water = _coffeeIngredient.Water,
            Milk = _coffeeIngredient.Milk,
            Sugar = _coffeeIngredient.Sugar,
        };
        
        return coffeeIngredient;
    }

    public bool Remove(CoffeeIngredient coffeeIngredient)
    {
        _coffeeIngredient.CoffeeBeans -= coffeeIngredient.CoffeeBeans;
        _coffeeIngredient.Water -= coffeeIngredient.Water;
        _coffeeIngredient.Milk -= coffeeIngredient.Milk;
        _coffeeIngredient.Sugar -= coffeeIngredient.Sugar;
        _coffeeIngredient.Syrup -= coffeeIngredient.Syrup;
        
        return true;
    }
}