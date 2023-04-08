interface IVehicle
{
	public int Mileage { get; set; }
	public bool HasDoors { get; } 
	public int NumberOfSeats { get; }
	public int NumberOfWheels { get; }
	public int NumberOfDoors { get; }

	public void Drive(int amount);
}