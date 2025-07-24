using CoffeeMachineProject.Enums;

namespace CoffeeMachineProject;

public class CoffeeMachine: ICoffeeMachine
{
    private IOrderRepository _orderRepository = new OrderRepository();

    private IOrderFactory _orderFactory = new OrderFactory();
    
    private ICoffeeIngredientFacade _coffeeIngredientFacade = new CoffeeIngredientFacade();

    private IAccount _account;
    
    private ICoffeePriceFacade _coffeePriceFacade = new CoffeePriceFacade();

    private ICoffeeOrderFacade _coffeeOrderFacade;
    
    private IAccountFacade _accountFacade;
    
    public CoffeeMachine(ICoffeeIngredientStorage storage, IAccount account)
    {
        _account = account;
        _coffeeOrderFacade = new CoffeeOrderFacade(storage, account);
        _accountFacade = new AccountFacade(_account);
    }
    public int SelectCoffee(CoffeeType coffeeType, CoffeeSize coffeeSize)
    {
        Order order = _orderFactory.CreateOrder(coffeeType, coffeeSize);
        
        _orderRepository.AddOrder(order);

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
        Order? order = _orderRepository.GetOrder(orderNumber);
        if (order == null)
        {
            return;
        }

        if (order.Deposit < order.Price)
        {
            Console.WriteLine("Not enough money.");
        }
        
        if (order.Deposit >= order.Price)
        {
            order.OrderStatus = OrderStatus.Created;
        }
        
        order.Deposit += amount;
    }

    public void AddWater(int orderNumber)
    {
        AddAdditional(orderNumber,
            _coffeeIngredientFacade.GetWaterAdditionalFacade(),
            _coffeePriceFacade.GetWaterAdditionalPriceFacade());
    }

    public void AddMilk(int orderNumber)
    {
        AddAdditional(orderNumber,
            _coffeeIngredientFacade.GetMilkAdditionalFacade(),
            _coffeePriceFacade.GetMilkAdditionalPriceFacade());
    }

    public void AddCoffeeBeans(int orderNumber)
    {
        AddAdditional(orderNumber,
            _coffeeIngredientFacade.GetBeansAdditionalFacade(),
            _coffeePriceFacade.GetBeansAdditionalPriceFacade());
    }

    public void AddSugar(int orderNumber)
    {
        AddAdditional(orderNumber,
            _coffeeIngredientFacade.GetSugarAdditionalFacade(),
            _coffeePriceFacade.GetSugarAdditionalPriceFacade());
    }

    public void AddSyrup(int orderNumber)
    {
        AddAdditional(orderNumber,
            _coffeeIngredientFacade.GetSyrupAdditionalFacade(),
            _coffeePriceFacade.GetSyrupAdditionalPriceFacade());
    }

    private void AddAdditional(int orderNumber,
        IAdditionalFacade additionalFacade, IAdditionalPriceFacade additionalPriceFacade)
    {
        Order? order = _orderRepository.GetOrder(orderNumber);
        if (order == null)
        {
            return;
        }
        
        additionalFacade.AddAdditional(order);
        additionalPriceFacade.UpdatePrice(order);
    }
    

    public Coffee? PrepareCoffee(int orderNumber)
    {
        Order? order = _orderRepository.GetOrder(orderNumber);
        
        return _coffeeOrderFacade.PrepareCoffee(order);
    }

    public double GiveChange(int orderNumber)
    {
        Order? order = _orderRepository.GetOrder(orderNumber);
        
        if (order == null)
        {
            return 0.0;
        }
        return _accountFacade.GiveChange(order);
    }
   
}