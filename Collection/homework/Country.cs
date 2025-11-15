namespace Collection.homework;

public class Country
{
    public string Name { get; set; }

    public bool IsInEu { get; set; }

    public Country(string name, bool isInEU)
    {
        Name = name;
        IsInEu = isInEU;
    }

    public override string ToString()
    {
        return $"{Name} (EU: {IsInEu})";
    }
}

