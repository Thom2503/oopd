public class Country
{
	private string _name;
	public string Name { get => _name; set => _name = value.ToUpper(); }
	public int Population { get; }
	public bool OverPopulation { get => Population > 1000; }

	public Country(string name, int population)
	{
		Name = name;
		Population = population;
	}
}