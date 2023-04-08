public class Car : Vehicle
{
	public string Model { get; }
	public string Make { get; }
	public int Year { get; }

	public Car(int mileage, int numberOfSeats, int numberOfWheels, int numberOfDoors, string model, string make, int year)
	    : base(mileage, true, numberOfSeats, numberOfWheels, numberOfDoors)
	{
		Model = model;
		Make = make;
		Year = year;
	}

	public override void Honk() => Console.WriteLine("Tut tut");
}