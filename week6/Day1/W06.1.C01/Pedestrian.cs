public class Pedestrian : Person, ICommute
{
    public Pedestrian(string name) : base(name) { }

	public void Move(int iDistance)
	{
		Console.WriteLine($"Walked {iDistance} kms");
	}
}