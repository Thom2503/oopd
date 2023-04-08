public class DiscountedProduct : Product, IDiscount
{
	public double Percentage { get; }

	public DiscountedProduct(string name, double price, string description, double percentage) : base(name, price, description)
	{
		Percentage = percentage;
	}
}