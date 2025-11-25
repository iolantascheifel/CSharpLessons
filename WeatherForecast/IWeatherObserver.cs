namespace WeatherForecast;

public interface IWeatherObserver
{
    void UpdateTemperature(int degrees);
}