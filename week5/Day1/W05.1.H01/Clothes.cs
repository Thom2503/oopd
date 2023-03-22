public class Clothes : Product
{
	public string Size;
	public string Material;

	public Clothes(string strName, double dbPrice, int iAmount, string strSize, string strMaterial) : base(strName, dbPrice, iAmount)
	{
		Size = strSize;
		Material = strMaterial;
	}

	public override string ToString()
	{
		return base.ToString() + $"; Size: {this.Size}; Material: {this.Material}";
	}
}