namespace OOPPrinciple.RS;

public class RocketStation
{
    public static void StartRocket(params IRocket[] rockets)
    {
        foreach (IRocket rocket in rockets)
        {
            Console.WriteLine($"Rocket station {rocket.Name} started");
        
            if (rocket.EnginePower < 1000)
            {
                Console.WriteLine($"Запуск ракеты не возможен");
                rocket.Stop();
            }
            else
            {
                rocket.Start();
            }
            Console.WriteLine($"Rocket station {rocket.Name} completed");
        }
    }
}