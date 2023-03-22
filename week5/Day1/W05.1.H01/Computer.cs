public class Computer : Electronics
{
	public Computer(string strName, double dbPrice, int iAmount, string strBrand, string strModel) : base(strName, dbPrice, iAmount, strBrand, strModel)
	{
	}

	public override void Restock()
	{
		base.Amount = 5;
	}

}