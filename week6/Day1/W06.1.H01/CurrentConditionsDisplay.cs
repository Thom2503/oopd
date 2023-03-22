public class CurrentConditionsDisplay : IObserver, IDisplay
{
	private double _temperature;
	private double _humidity;
	private IObservable _observable;

	public CurrentConditionsDisplay(IObservable observable) => _observable = observable;

	public void Update()
	{
		if (this._observable is WeatherData weatherData)
		{
			this._temperature = weatherData.Temperature;
			this._humidity = weatherData.Humidity;
		}
	}

	public void Display() => Console.WriteLine($"Current conditions: {this._temperature}C degrees and {this._humidity}% humidity");
}