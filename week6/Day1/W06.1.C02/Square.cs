public class Square : IDrawable, IResizable
{
    public int Size { get; private set; }
    public Square(int size) => Size = size;

	public void Resize(double dbScale)
	{
		this.Size = (int)Math.Floor(this.Size * dbScale);
	}

	public void Draw()
	{
		for (int i = 0; i < this.Size; i++)
			Console.WriteLine(String.Concat(Enumerable.Repeat("*", this.Size)));
		Console.WriteLine("");
	}
}