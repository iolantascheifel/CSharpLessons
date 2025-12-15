namespace WeatherForecast;

class Program
{
    static void Main(string[] args)
    {
       WeatherAnalyzer analyzer = new WeatherAnalyzer();
       
       MobileWeatherClient mobileClient = new MobileWeatherClient();
       DesktopWeatherClient desktopClient = new DesktopWeatherClient();

       analyzer.OnUpdateTemperature += mobileClient.UpdateTemperature; // добавить в цепочку вызовов
       analyzer.OnUpdateTemperature += null;
       
       analyzer.UpdateTemperature();
       analyzer.UpdateTemperature();
       analyzer.UpdateTemperature();
       analyzer.UpdateTemperature();
    }
}