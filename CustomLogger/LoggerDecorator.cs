namespace CustomLogger;

public abstract class LoggerDecorator: ILogger
{
    protected ILogger _logger;

    protected LoggerDecorator(ILogger logger)
    {
        _logger = logger;
    }

    public abstract void Log(string message);
}