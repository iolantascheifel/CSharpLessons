namespace Threads;

public class Vector
{
    public required int X {get; set;}
    public required int Y {get; set;}
    public required int Z {get; set;}

    public override string ToString()
    {
        return $"X: {X}, Y: {Y}, Z: {Z}";
    }
    
}