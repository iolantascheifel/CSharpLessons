namespace WeatherForecast;

public class WeatherAnalyzer
{
    private int _currentTemperature = Random.Shared.Next(-20, 20);
    private event Action<int> _onUpdateTemperature;
    public event Action<int>? OnUpdateTemperature
    {
        add
        {
            if (value != null)
            {
                _onUpdateTemperature += value;
            }
        }
        remove
        {
            _onUpdateTemperature -= value;   
        }
    }
    
    public void UpdateTemperature()
    {
        int nextTemperature = Random.Shared.Next(-20, 20);
        if (nextTemperature != _currentTemperature)
        {
            _currentTemperature = nextTemperature;
            _onUpdateTemperature(nextTemperature);
        }
    }
}