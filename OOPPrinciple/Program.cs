using OOPPrinciple.Polymorphism;
using OOPPrinciple.RS;
using OOPPrinciple.CurrencyConverter;

namespace OOPPrinciple;

class Program
{
    static void Main(string[] args)
    {
        Student student = new Student("Adam Smith", TypeOfStudy.Courses) // в конструктор
        { // инициализатор
            TypeOfStudy = TypeOfStudy.University,
            Gender = "Male"
        };
        
        // Console.WriteLine(student.FullName);
        student.Study();
        // Console.WriteLine(student.StudyLevel);
        student.Study();
        // Console.WriteLine(student.StudyLevel);
        
        // Guid id = Guid.NewGuid();  // Создаёт новый уникальный GUID
        // Console.WriteLine(DateTime.Now); 
        // Console.WriteLine(DateTimeOffset.UtcNow);
        
        Console.WriteLine(student.Gender);
        ((IAnimal) student).Eat();
        ((IPerson) student).Eat();
        student.Sleep();
        student.Study();
        student.PassExam();
        
        IRocket souz = new Souz();
        FalconS falconS = new FalconS();
        // RocketStation rocketStation = new RocketStation();
        // IRocket[] rockets = new IRocket[] { souz, falconS };
        RocketStation.StartRocket(souz, falconS);
        // RocketStation.StartRocket(falconS);
        // rocketStation.StartRocket(souz);
        // rocketStation.StartRocket(falcon S);

        Person person = student;
        person.Walking();
        
        Customer[] customers = new Customer[]
        {
            new RegularCustomer(),
            new PremiumCustomer(),
            new VIPCustomer()
        };
        
        decimal purchaseAmount = 1000m;

        foreach (Customer customer in customers)
        {
            customer.AddPurchase(purchaseAmount);
            Console.WriteLine(customer);
        }
        
        DeliveryCalculator calculator = new DeliveryCalculator();
        
        decimal cost1 = calculator.Calculate(5);                                            
        decimal cost2 = calculator.Calculate(5, 100);                              
        decimal cost3 = calculator.Calculate(5, 100, true);                 
        decimal cost4 = calculator.Calculate(3.5, 50, false); 
        
        
        
        Console.WriteLine($"Стоимость 1 (только вес): {cost1.Convert()}");          // 50
        Console.WriteLine($"Стоимость 2 (вес + дистанция): {cost2.Convert()}");     // 250
        Console.WriteLine($"Стоимость 3 (экспресс): {cost3.Convert()}");            //350
        Console.WriteLine($"Стоимость 4 (без экспресса): {cost4.Convert()}");

        decimal cost = 22;
        Console.WriteLine(cost.Convert());
    }
}