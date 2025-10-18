namespace OOPAgain;

public class RocketStation
{
    public void StartRocket(Rocket rocket)
    {
        rocket.Prepare();
        Console.WriteLine($"{rocket.Name} with {rocket.Volume}volume preparing..");
        
        if (rocket.Volume >= 2000)
        {
            rocket.Launch();
            Console.WriteLine($"{rocket.Name} with {rocket.Volume}volume launching..");
        }
        else
        {
            rocket.Finish();
            Console.WriteLine($"{rocket.Name} with {rocket.Volume}volume stopping..");
        }
    }
}