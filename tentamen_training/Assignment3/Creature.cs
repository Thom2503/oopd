public abstract class Creature
{
	private int _height;
    public virtual int Height { get => _height; protected set => _height = value < 0 ? 0 : value; }
	private int _weight;
	public int Weight { get => _weight; protected set => _weight = value < 0 ? 0 : value; }

    public Creature(int iHeight, int iWeight)
    {
        Height = iHeight;
        Weight = iWeight;
    }

    public virtual void PrintInfo() => Console.Write($"Height: {Height}\nWeight: {Weight}");

    public abstract bool Eat(string strFood);
}