public class WeatherData
{
    //Change from List to array
    private readonly double[] _data;
    public WeatherData(double[] data) => _data = data;

	public int NumberOfReadings { get => _data.Length; }

	public double GetHighestTemperature() => _data.Max();

}