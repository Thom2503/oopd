public class Product : IProduct
{
	public string Name { get; }
	public double Price { get; }
	public string Description { get; }

	public Product(string name, double price, string description)
	{
		Name = name;
		Price = price;
		Description = description;
	}

	public override string ToString() => $"{Name} ({Description}) = {Price}";
}