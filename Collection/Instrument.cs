namespace Collection;

public class Instrument
{
    public string Name { get; set; }

    public int Resource { get; set; }

    public bool IsBroken
    {
        get
        {
            return Resource <= 50;
        }
    }
    
}