public class Promotion : IPromotion
{
	public List<DiscountedProduct> Promotions { get; }

	public  Promotion() => Promotions = new List<DiscountedProduct>();

	public void Add(DiscountedProduct discountedProduct)
	{
		if (discountedProduct == null)
			return;

		foreach (DiscountedProduct _discountedProduct in Promotions)
		{
			if (_discountedProduct.Name == discountedProduct.Name)
				return;
		}

		Promotions.Add(discountedProduct);
	}

	public void Remove(string name)
	{
		if (name == null)
			return;

		foreach (DiscountedProduct _discountedProduct in Promotions)
		{
			if (_discountedProduct.Name == name)
				Promotions.Remove(_discountedProduct);
		}

		return;
	}

	public override string ToString() => $"The promotion includes {Promotions.Count()} # of Discounted Items";
}