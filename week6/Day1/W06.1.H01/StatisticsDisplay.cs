public class StatisticsDisplay : IObserver, IDisplay
{
	private IObservable _observable;
	private double _minTemperature;
	private double _maxTemperature;
	private double _avgTemperature;

	private double _temperatureSum;
	private int _timesUpdated;

	public StatisticsDisplay(IObservable observable) => this._observable = observable;

	public void Update()
	{
		if (this._observable is WeatherData weatherData)
		{
			if (weatherData.Temperature > this._maxTemperature)
			{
				// als er een nieuwe max is kan de oude max de min worden.
				this._minTemperature = this._maxTemperature;
				this._maxTemperature = weatherData.Temperature;
			}
			else if (weatherData.Temperature < this._minTemperature)
			{
				this._minTemperature = weatherData.Temperature;
			}
			this._timesUpdated++;
			this._temperatureSum += weatherData.Temperature;

			this._avgTemperature = this._temperatureSum / this._timesUpdated;
		}
	}

	public void Display() => Console.WriteLine($"Avg/Min/Max temperature = {this._avgTemperature}/{this._minTemperature}/{this._maxTemperature}");

}