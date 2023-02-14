public class ShoppingCart
{
	public List<GroupedShopItem> Groceries;

	public ShoppingCart()
	{
		Groceries = new List<GroupedShopItem>();
	}

	public void AddItem(ShopItem shopItem)
	{
		GroupedShopItem groupedItem = this.FindItem(shopItem);

		if (groupedItem == null)
		{
			GroupedShopItem newGroupItem = new GroupedShopItem(shopItem);	
			this.Groceries.Add(newGroupItem);
		} else
		{
			groupedItem.Quantity++;
		}
	}

	public GroupedShopItem FindItem(ShopItem shopItem)
	{
		foreach (GroupedShopItem groupedItem in this.Groceries)
		{
			if (groupedItem.Item.ID == shopItem.ID)
				return groupedItem;
		}

		return null;
	}

	public string Contents()
	{
		string strContents = "";
		foreach (GroupedShopItem groupedItem in this.Groceries)
		{
			strContents += $"{groupedItem.Item.Name} {groupedItem.Quantity}\n";
		}

		return strContents;
	}

	public double TotalPrice()
	{
		double dbTotalPrice = 0.0;

		foreach (GroupedShopItem groupedItem in this.Groceries)
		{
			dbTotalPrice += (groupedItem.Item.Price * groupedItem.Quantity);
		}

		return dbTotalPrice;
	}
}