namespace WeatherForecast;

public delegate void UpdateTemperature(int degrees);
public class WeatherAnalyzer
{
    private int _currentTemperature = Random.Shared.Next(-20, 20);
    public UpdateTemperature OnUpdateTemperature { get; set; }

    public void UpdateTemperature()
    {
        int nextTemperature = Random.Shared.Next(-20, 20);
        if (nextTemperature != _currentTemperature)
        {
            _currentTemperature = nextTemperature;
            OnUpdateTemperature(nextTemperature);
        }
    }
}