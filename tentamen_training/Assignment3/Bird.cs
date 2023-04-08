public class Bird : Creature, IFly, ISing
{
	private int _height;
    public override int Height
	{ 
		get => _height;
		protected set
		{ 
			_height = value;
			if (value < 0)
			{
				_height = 0;
			}
			else if (value > 20)
			{
				_height = 20;
			}
		}
	}

    public int Altitude { get; set; }

    public Bird(int iHeight, int iWeight) : base(iHeight, iWeight)
    {
        //Height = iHeight < 0 ? 20 : iHeight;
    }

    public void Fly() => Altitude += 1;

    public void Land() => Altitude = 0;

    public string Sing() => "Chirp chirp";

    public override bool Eat(string strFood)
    {
        if (strFood == "Worm" || strFood == "Seed" || strFood == "Insect")
        {
            Height += 3;
            Weight += 5;
            return true;
        }

        return false;
    }

    public override void PrintInfo() => Console.Write($"Height: {Height}\nWeight: {Weight}\nAltitude: {Altitude}\n");
}