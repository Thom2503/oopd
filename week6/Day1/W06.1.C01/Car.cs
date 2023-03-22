class Car : ICommute
{
    public int Mileage { get; private set; }
    public Car() => Mileage = 0;

	public void Move(int iDistance)
	{
		this.Mileage += iDistance;
		Console.WriteLine($"Drove {iDistance} kms");
		Console.WriteLine($"Mileage: {this.Mileage} kms");
	}
}