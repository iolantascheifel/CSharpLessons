namespace ZooApp;

public class ZooBuilder
{
    private readonly ZooManager _zooManager = new();
    private readonly AnimalFactory _factory = new();

    public ZooBuilder AddAnimal(string type, string name, int age)
    {
        var animal = _factory.CreateAnimal(type, name, age);
        _zooManager.AddAnimal(animal);
        return this;
    }

    public ZooManager Build()
    {
        return _zooManager;
    }
}