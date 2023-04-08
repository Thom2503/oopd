public class Bike : Vehicle
{
	public string Model { get; }

	public Bike(int mileage, int numberOfSeats, int numberOfWheels, string model) : base(mileage, false, numberOfSeats, numberOfWheels)
	{
		Model = model;
	}

	public override void Honk() => Console.WriteLine("Tring tring");
}