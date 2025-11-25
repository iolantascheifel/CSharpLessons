namespace WeatherForecast;

public class MobileWeatherClient: IWeatherObserver
{
    public void UpdateTemperature(int degrees)
    {
        Console.WriteLine($"[Mobile Weather client] updated {degrees} degrees");
    }
}