public class ShopItem
{
	public string ID;
	public string Name;
	public double Price;

	public ShopItem(string iID, string strName, double dbPrice)
	{
		ID = iID;
		Name = strName;
		Price = dbPrice;
	}

	public ShopItem(string iID, double dbPrice) : this(iID, "Unknown", dbPrice) {}
}