using System;

namespace Program;

public class Program
{
	public static void Main(string[] args)
	{
		Promotion promotion = new Promotion();

		List<DiscountedProduct> discountedProducts =  new List<DiscountedProduct>()
		{
			new DiscountedProduct("Glow in the dark plant", 10.0, "A plant that glows in the dark", 10.0),
			new DiscountedProduct("Colour changing crystal", 70.0, "A crystal that changes color depending on the weather", 5.0),
			null,
			new DiscountedProduct("Invisible potion", 500.0, "A potion that makes you invisible for 30 seconds", 10.0),
			new DiscountedProduct("Telekenetic Meteorite", 1000.00, "A piece of meteorite that grants you telekinetic powers", 25.0),
		};

		double totalPromotionPercentage = 0;
		foreach (DiscountedProduct _discountedProduct in discountedProducts)
		{
			promotion.Add(_discountedProduct);

			if (_discountedProduct == null)
				continue;

			totalPromotionPercentage += _discountedProduct.Percentage;
			double promotionPrice = (_discountedProduct.Price / _discountedProduct.Percentage) * 100;
			Console.WriteLine($"The product {_discountedProduct.Name} now costs {promotionPrice}");
		}
		Console.WriteLine(totalPromotionPercentage);
		Console.WriteLine(promotion.ToString());
	}
}