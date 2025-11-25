namespace WeatherForecast;

public class DesktopWeatherClient: IWeatherObserver
{
    public void UpdateTemperature(int degrees)
    {
        Console.WriteLine($"[Desktop Weather client] updated {degrees} degrees");
    }
}