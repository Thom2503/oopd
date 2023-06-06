public class Inventory
{
	private Dictionary<string, Product> _products = new Dictionary<string, Product>();

	public void AddProduct(string name, double price, int quantity) => _products[name] = new Product(name, price, quantity);

	public void AddProduct(string name, double price) => _products[name] = new Product(name, price, 0);

	public void RemoveProduct(string name) => _products.Remove(name);

	public Product GetProduct(string name)
	{
		foreach (KeyValuePair<string, Product> _product in _products)
			if (_product.Key == name && _product.Value.Name == name)
				return _product.Value;

		return null;
	}

	public string GetInventorySummary()
	{
		double totalPrice = 0.0;
		int totalQuantity = 0;
		foreach (Product _product in _products.Values)
		{
			totalPrice += (_product.Price * _product.Quantity);
			totalQuantity += _product.Quantity;
		}
		return $"Total products: {totalQuantity}\nTotal value: ${totalPrice}";
	}
}