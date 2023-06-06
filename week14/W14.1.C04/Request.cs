public class Request
{
	public string Name { get; set; }
	public string Description { get; set; }
	public string CustomerName { get; set; }

	public Request(string name, string description, string customerName)
	{
		Name = name;
		Description = description;
		CustomerName = customerName;
	}

	public override string ToString()
	{
		string output = "";
		output += $"Name: {Name}\n";
		output += $"Description: {Description}\n";
		output += $"Customer Name: {CustomerName}\n";
		return output;
	}
}