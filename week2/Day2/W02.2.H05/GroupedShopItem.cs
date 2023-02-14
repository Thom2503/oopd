public class GroupedShopItem
{
	public ShopItem Item;
	public int Quantity;

	public GroupedShopItem(ShopItem shopItem)
	{
		Item = shopItem;
		Quantity = 1;
	}
}