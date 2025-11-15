namespace ZooApp;

public class HealthyAnimalDecorator : IFeedable
{
    private readonly IFeedable _animal;
    private readonly bool _isHealthy;

    public HealthyAnimalDecorator(IFeedable animal, bool isHealthy)
    {
        _animal = animal;
        _isHealthy = isHealthy;
    }

    public void Feed()
    {
        if (_isHealthy)
        {
            _animal.Feed();
        }
        else
        {
            Console.WriteLine("Животное больно и не может есть сейчас!");
        }
    }
}