namespace CustomLogger;

public delegate void Log(string message);

public class Calculator
{
    public Log OnLog { get; set; }
    
    public int Add(int a, int b)
    {
        OnLog( $"{a} + {b} = {a + b}");
        return a + b;
    }

    public int Divide(int a, int b)
    {
        OnLog( $"{a} / {b} = {a / b}");
        return a / b;
    }

    public int Multiply(int a, int b)
    {
        OnLog($"{a} * {b} = {a * b}");
        return a * b;
    }

    public int Subtract(int a, int b)
    {
        OnLog($"{a} - {b} = {a - b}");
        return a - b;
    }
    
}