namespace OOPPrinciple.RS;

public class Souz: Rocket
{
    public Souz() : base("Союз", 900)
    {
    }

    public override void Check()
    {
        Console.WriteLine("Союз: Проверка систем");
    }

    public override void Start()
    {
        Console.WriteLine("Союз: Запуск");
    }

    public override void Stop()
    {
        Console.WriteLine("Союз: Остановка");
    }
}