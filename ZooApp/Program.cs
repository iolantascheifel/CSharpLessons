namespace ZooApp;

class Program
{
    static void Main(string[] args)
    {
        Lion lion = new Lion("Misha", 8, new List<string>() { "lion" }, false);
        Console.WriteLine($"Lion name: {lion.Name}");
    }
}