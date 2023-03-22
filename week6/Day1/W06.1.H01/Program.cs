using System;

public class Program
{
    public static void Main(string[] args)
    {
        WeatherData weatherData = new WeatherData();

        CurrentConditionsDisplay currentDisplay = new CurrentConditionsDisplay(weatherData);
        StatisticsDisplay statsDisplay = new StatisticsDisplay(weatherData);

        weatherData.SetMeasurements(80, 65, 30.4);
        weatherData.SetMeasurements(82, 70, 29.2);
        currentDisplay.Display();
        statsDisplay.Display();
	}
}