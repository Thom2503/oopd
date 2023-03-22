public class WeatherData : IObservable
{
	public double Temperature;
	public double Humidity;
	public double Pressure;
	private List<IObserver> _observers = new List<IObserver>();

	public void RegisterObserver(IObserver observer) => this._observers.Add(observer);

	public void RemoveObserver(IObserver observer) => this._observers.Remove(observer);
	//{
	//	int iIndex = this._observers.IndexOf(observer);
	//	if (iIndex > 0)
	//		this._observers.RemoveAt(iIndex);
	//}

	public void NotifyObservers()
	{
		foreach (IObserver observer in this._observers)
			observer.Update();
	}

	public void SetMeasurements(double dbTemp, double dbHum, double dbPress)
	{
		this.Temperature = dbTemp;
		this.Humidity = dbHum;
		this.Pressure = dbPress;

		this.MeasurementsChanged();
	}

	public void MeasurementsChanged() => this.NotifyObservers();
}