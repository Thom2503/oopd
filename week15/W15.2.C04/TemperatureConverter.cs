public enum TemperatureUnit
{
	Celsius,
	Fahrenheit,
	Kelvin
}

public static class TemperatureConverter
{
	public static string ConvertToString(TemperatureUnit temperatureUnit)
	{
		if (temperatureUnit.ToString() == "Celsius")
		{
			return "C";
		}
		else if (temperatureUnit.ToString() == "Fahrenheit")
		{
			return "F";
		}
		else
		{
			return "K";
		}
	}

	public static TemperatureUnit ConvertToEnum(string temperatureUnit)
	{
		if (temperatureUnit == "C")
		{
			return TemperatureUnit.Celsius;
		}
		else if (temperatureUnit == "F")
		{
			return TemperatureUnit.Fahrenheit;
		}
		else if (temperatureUnit == "K")
		{
			return TemperatureUnit.Kelvin;
		}
		else
		{
			throw new ArgumentException("Invalid temperature unit string");
		}
	}
}