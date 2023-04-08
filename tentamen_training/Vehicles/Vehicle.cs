public abstract class Vehicle : IVehicle
{
	private int _mileage;
	public int Mileage { get => _mileage; set => _mileage = value < 0 ? 0 : value; }
	public bool HasDoors { get; }
	public int NumberOfSeats { get; }
	public int NumberOfWheels { get; }
	public int NumberOfDoors { get; }

	public Vehicle(int mileage, bool hasDoors, int numberOfSeats, int numberOfWheels) : this(mileage, hasDoors, numberOfSeats, numberOfWheels, 0) {}
	public Vehicle(int mileage, bool hasDoors, int numberOfSeats, int numberOfWheels, int NumberOfDoors)
	{
		Mileage = mileage;
		HasDoors = hasDoors;
		NumberOfSeats = numberOfSeats;
		NumberOfWheels = numberOfWheels;
	}

	public abstract void Honk();

	public void Drive(int amount) => Mileage += amount;
}