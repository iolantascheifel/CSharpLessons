namespace WeatherForecast;

class Program
{
    static void Main(string[] args)
    {
       WeatherAnalyzer analyzer = new WeatherAnalyzer();
       
       MobileWeatherClient mobileClient = new MobileWeatherClient();
       DesktopWeatherClient desktopClient = new DesktopWeatherClient();
       
       analyzer.AddObserver(mobileClient);
       analyzer.AddObserver(desktopClient);
       
       analyzer.UpdateTemperature();
       analyzer.UpdateTemperature();
       analyzer.UpdateTemperature();
       analyzer.UpdateTemperature();
    }
}