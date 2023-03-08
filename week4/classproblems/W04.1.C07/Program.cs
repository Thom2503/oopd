using Newtonsoft.Json;

namespace Program;

public class Program
{
	public static void Main(string[] args)
	{
		List<Person> lPersons = new();
		try
		{
			StreamReader reader = new StreamReader("People.json");
			string File2JSON = reader.ReadToEnd();
			lPersons = JsonConvert.DeserializeObject<List<Person>>(File2JSON)!;
			reader.Close();
			reader.Dispose();

			foreach (Person person in lPersons)
				foreach (Car personCar in person.OwnedCars)
					for (int i = 0; i < 5; i++)
						personCar.Drive();

			StreamWriter writer = new StreamWriter("People.json");
			string List2JSON = JsonConvert.SerializeObject(lPersons);
			writer.Write(List2JSON);
			writer.Close();
			writer.Dispose();
		}
		catch (FileNotFoundException ex)
		{
			Console.WriteLine($"Missing JSON file. {ex.Message}");
		}
		catch (JsonReaderException ex)
		{
			Console.WriteLine($"Invalid JSON. {ex.Message}");
		}
	}
}