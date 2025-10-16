namespace ZooApp;

public interface IAnimal
{
    string Name { get; set; }
    int Age { get; set; }
    List<string> Species { get; set; }
    bool IsHungry { get; set; }
    void Eat();
}