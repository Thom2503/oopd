public class Die
{
	public string Color;
	public int Sides;
	public int Value;

	public Die(string strColor, int iSides)
	{
		Color = strColor;
		Sides = iSides;
	}

	public override string ToString() => $"Sides: {Sides}, Color: {Color}, Value: {Value}";

	public void Roll()
	{
		Random rand = new Random();

		this.Value = rand.Next(1, Sides + 1);
	}
}