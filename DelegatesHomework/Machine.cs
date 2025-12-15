namespace DelegatesHomework;

public class Machine
{
    private int _counter = 0;

    private event Action<Part>? _onPartProduced;
    public event Action<Part>? OnPartProduced
    {
        add
        {
            if (value != null)
                _onPartProduced += value;
        }
        remove
        {
            _onPartProduced -= value;
        }
    }

    public void Produce()
    {
        var part = new Part
        {
            Id = ++_counter,
            Name = "Bolt"
        };

        Console.WriteLine($"Machine: Produced part #{part.Id}");

        _onPartProduced?.Invoke(part);
    }
}
