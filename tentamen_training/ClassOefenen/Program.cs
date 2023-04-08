public class Program
{
	public static void Main(string[] args)
	{
		Country netherlands = new Country("the Netherlands", 10000);
		Country vatican = new Country("Vatican", 100);

		Console.WriteLine(netherlands.Name);
		Console.WriteLine(netherlands.OverPopulation);
		Console.WriteLine(vatican.Name);
		Console.WriteLine(vatican.OverPopulation);
	}
}