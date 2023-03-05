using Newtonsoft.Json;

public class Program
{
	public static void Main(string[] args)
	{
		StreamReader reader = new StreamReader("Cars.json");
		string File2JSON = reader.ReadToEnd();
		List<Car> lCars = JsonConvert.DeserializeObject<List<Car>>(File2JSON)!;
		reader.Close();
		reader.Dispose();

		foreach (Car car in lCars)
		{
			for (int i = 0; i < 5; i++)
			{
				car.Drive();
			}
		}

		StreamWriter writer = new StreamWriter("Cars.json");
		string List2JSON = JsonConvert.SerializeObject(lCars);
		writer.Write(List2JSON);
		writer.Close();
		writer.Dispose();
	}
}