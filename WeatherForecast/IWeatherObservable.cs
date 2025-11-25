namespace WeatherForecast;

public interface IWeatherObservable
{
    public void AddObserver(IWeatherObserver weatherObserver);
    public void RemoveObserver(IWeatherObserver weatherObserver);
    public void NotifyObservers();
    public void UpdateTemperature();
}