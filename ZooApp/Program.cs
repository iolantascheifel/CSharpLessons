namespace ZooApp;

class Program
{
    static void Main(string[] args)
    {
        Animal[] animals = {new Lion(), new Penguin(), new Giraffe()};

        foreach (var animal in animals)
        {
            animal.MakeSound();
        }
        Giraffe giraffe = new Giraffe();
        giraffe.Care();
        
        var builder = new ZooBuilder();

        var zoo = builder
            .AddAnimal("penguin", "Пингвин Петр", 3)
            .Build();

        zoo.FeedAnimals();
        zoo.TakeCareOfAnimals();
    }
}