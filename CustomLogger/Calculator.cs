namespace CustomLogger;

public class Calculator
{
    private ILogger _logger;
    public Calculator(ILogger fileLogger)
    {
        _logger = fileLogger;
    }
    
    public int Add(int a, int b)
    {
        _logger.Log( $"{a} + {b} = {a + b}");
        return a + b;
    }

    public int Divide(int a, int b)
    {
        _logger.Log( $"{a} / {b} = {a / b}");
        return a / b;
    }

    public int Multiply(int a, int b)
    {
        _logger.Log($"{a} * {b} = {a * b}");
        return a * b;
    }

    public int Subtract(int a, int b)
    {
        _logger.Log($"{a} - {b} = {a - b}");
        return a - b;
    }
    
}