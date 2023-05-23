using Newtonsoft.Json;

public static class ContainerManager
{
	public static void Start(string path)
	{
		foreach (var file in Directory.EnumerateFiles(path))
		{
			List<Container> fileContainers = ContainerManager.ProcessManifest(file);
			foreach (Container _container in fileContainers)
				Console.WriteLine(_container.ToString());
		}
	}

	public static List<Container> ProcessManifest(string file)
	{
		List<Container> containers = new List<Container>();
		try
		{
			StreamReader reader = new StreamReader(file);
			string JSON2String = reader.ReadToEnd();
			containers = JsonConvert.DeserializeObject<List<Container>>(JSON2String)!;
			reader.Close();
			reader.Dispose();
		}
		catch (FileNotFoundException ex)
		{
			Console.WriteLine($"Missing JSON file. {ex.Message}");
		}
		catch (JsonReaderException ex)
		{
			Console.WriteLine($"Invalid JSON. {ex.Message}");
		}
		return containers;
	}	

	public static List<Container> SearchByOrigin(List<Container> containers, string origin) => containers.FindAll(x => x.Origin == origin);

	public static Container SearchForHeaviest(List<Container> containters) => containters.MaxBy(x => x.Weight);
}