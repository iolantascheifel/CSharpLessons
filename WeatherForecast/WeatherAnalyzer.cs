namespace WeatherForecast;

public class WeatherAnalyzer: IWeatherObservable
{
    private List<IWeatherObserver> _weatherObservers = new List<IWeatherObserver>();
    private int _currentTemperature = Random.Shared.Next(-20, 20);
    
    public void AddObserver(IWeatherObserver weatherObserver)
    {
        _weatherObservers.Add(weatherObserver);
    }

    public void RemoveObserver(IWeatherObserver weatherObserver)
    {
        _weatherObservers.Remove(weatherObserver);
    }

    public void NotifyObservers()
    {
        foreach (var observer in _weatherObservers)
        {
           observer.UpdateTemperature(_currentTemperature);
        }
    }

    public void UpdateTemperature()
    {
        int nextTemperature = Random.Shared.Next(-20, 20);
        if (nextTemperature != _currentTemperature)
        {
            _currentTemperature = nextTemperature;
            NotifyObservers();
        }
    }
}