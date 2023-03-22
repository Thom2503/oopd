public class Product
{
	public string Name;
	public double Price;
	public int Amount;

	public Product(string strName, double dbPrice, int iAmount)
	{
		Name = strName;
		Price = dbPrice;
		Amount = iAmount;
	}

	public virtual void Sell(int iAmount)
	{
		if (this.Amount < iAmount)
		{
			Console.WriteLine($"{this.Name} is out of stock.");
		}
		else
		{
			this.Amount -= iAmount;
			Console.WriteLine($"{iAmount} units of {this.Name} have been sold.");
		}
	}

	public override string ToString() => $"Name: {this.Name}; price: {this.Price}; stock: {this.Amount}";
}