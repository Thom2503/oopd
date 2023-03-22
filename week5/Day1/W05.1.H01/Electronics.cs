public class Electronics : Product
{
	public string Brand;
	public string Model;
	public static int MinimumStock = 10;

	public Electronics(string strName, double dbPrice, int iAmount, string strBrand, string strModel) : base(strName, dbPrice, iAmount)
	{
		Brand = strBrand;
		Model = strModel;
	}

	public virtual void Restock()
	{
		base.Amount = 10;
	}

	public override void Sell(int iAmount)
	{
		base.Sell(iAmount);
		if (base.Amount <= Electronics.MinimumStock)
			this.Restock();
	}

	public override string ToString() => $"Name: {base.Name} ({this.Brand} {this.Model}); price: {base.Price}; stock: {base.Amount}";
}