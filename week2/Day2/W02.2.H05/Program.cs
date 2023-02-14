using System;

namespace Program;

public class Program
{
	public static void Main(string[] args)
	{
		ShopItem eggs = new ShopItem(1, "Eggs", 4.74);
		ShopItem milk = new ShopItem(2, "Milk", 5.99);
		ShopItem kaas = new ShopItem(3, "Cheese", 11.58);

		ShoppingCart shoppingCart = new ShoppingCart();
		shoppingCart.AddItem(eggs);
		shoppingCart.AddItem(eggs);
		shoppingCart.AddItem(milk);
		Console.WriteLine(shoppingCart.Contents());
		Console.WriteLine(shoppingCart.TotalPrice());
	}
}