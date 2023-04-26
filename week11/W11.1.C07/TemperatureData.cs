public class WeatherData
{
    //Change from List to array
    private readonly double[] _data;
    public WeatherData(double[] data) => _data = data;

	public int NumberOfReadings { get => _data.Length; }

	public double GetHighestTemperature() => _data.Max();

    public void Sort(bool isReverse)
    {
        for (int i = 0; i < NumberOfReadings - 1; i++)
        {
            for (int j = i; j < NumberOfReadings - 1 - i; j++)
            {
                if (_data[j] > _data[j + 1])
                {
                    double tmpData = _data[j];
                    _data[j] = (double)_data[j + 1];
                    _data[j + 1] = (double)tmpData;
                }
            }
        }

        if (isReverse == false)
            Array.Reverse(_data);
    }

    public void PrintTemperatures()
    {
        foreach (double _temp in _data)
            if (_temp < 0)
                Console.WriteLine(_temp.ToString("f1"));
            else
                Console.WriteLine(_temp);
    }

    public double[] GetTemperaturesSorted(bool isReverse)
    {
        double[] sortedData = new double[NumberOfReadings];
        Array.Copy(_data, sortedData, NumberOfReadings);
        if (isReverse == false)
            Array.Reverse(sortedData);

        return sortedData;
    }

}