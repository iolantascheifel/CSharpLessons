using CoffeeMachineProject.Enums;

namespace CoffeeMachineProject;

public class CoffeeIngredientFacade: ICoffeeIngredientFacade
{
    public const double BaseBeans = 8.0;
    
    public  const double BaseMilk = 100.0;
    
    public const double BaseSugar = 5.0;

    public const double BaseWater = 50.0;
    
    public const double BaseSyrup = 4.0;
    
    private IRepository<Unit, CoffeeIngredient> _repository;

    public CoffeeIngredientFacade(IRepository<Unit, CoffeeIngredient> repository)
    {
        _repository = repository;
    }
    
    public CoffeeIngredient GetLatteIngredient()
    {
        return new CoffeeIngredient()
        {
            CoffeeBeans = BaseBeans,
            Milk = BaseMilk * 2,
        };
    }

    public CoffeeIngredient GetEspressoIngredient()
    {
        return new CoffeeIngredient()
        {
            CoffeeBeans = BaseBeans,
            Water = BaseWater,
        };
    }

    public CoffeeIngredient GetCappuccinoIngredient()
    {
        return new CoffeeIngredient()
        {
            CoffeeBeans = BaseBeans,
            Water = BaseWater,
            Milk = BaseMilk,
        };
    }

    public bool HasIngredients(CoffeeIngredient coffeeIngredient)
    {
       CoffeeIngredient coffeeIngredients = _repository.Get(new Unit())!;
       
       if (coffeeIngredients.CoffeeBeans < coffeeIngredient.CoffeeBeans)
       {
           Console.WriteLine("Not enough beans");
           return false;
       }

       if (coffeeIngredients.Water < coffeeIngredient.Water)
       {
           Console.WriteLine("Not enough water");
           return false;
       }

       if (coffeeIngredients.Milk < coffeeIngredient.Milk)
       {
           Console.WriteLine("Not enough milk");
           return false;
       }

       if (coffeeIngredients.Sugar < coffeeIngredient.Sugar)
       {
           Console.WriteLine("Not enough sugar");
           return false;
       }
        
       if (coffeeIngredients.Syrup < coffeeIngredient.Syrup)
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
            _repository.Add(ingredient);
        }
        _repository.Remove(ingredient);
    }

    public void UpdateIngredientsByCoffeeSize(CoffeeIngredient coffeeIngredient, CoffeeSize coffeeSize)
    {
        double coefficient = (double)coffeeSize / (double)CoffeeSize.S;

        coffeeIngredient.CoffeeBeans *= coefficient;
        coffeeIngredient.Water *= coefficient;
        coffeeIngredient.Milk *= coefficient;
        coffeeIngredient.Syrup *= coefficient;
    }

    public IAdditionalFacade GetMilkAdditionalFacade()
    {
        return new MilkAdditionalFacade();
    }

    public IAdditionalFacade GetWaterAdditionalFacade()
    {
        return new WaterAdditionalFacade();
    }

    public IAdditionalFacade GetBeansAdditionalFacade()
    {
        return new BeansAdditionalFacade();
    }

    public IAdditionalFacade GetSugarAdditionalFacade()
    {
        return new SugarAdditionalFacade();
    }
    
    public IAdditionalFacade GetSyrupAdditionalFacade()
    {
        return new SyrupAdditionalFacade();
    }
}