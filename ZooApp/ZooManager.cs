namespace ZooApp;

public class ZooManager
{
    private readonly List<Animal> _animals = new();

    public void AddAnimal(Animal animal)
    {
        _animals.Add(animal);
    }

    public void FeedAnimals()
    {
        foreach (var animal in _animals.OfType<IFeedable>())
        {
            animal.Feed();
        }
    }

    public void TakeCareOfAnimals()
    {
        foreach (var animal in _animals.OfType<ICareable>())
        {
            animal.Care();
        }
    }
}