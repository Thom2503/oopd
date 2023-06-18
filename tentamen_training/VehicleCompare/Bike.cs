public class Bike : IVehicle, IComparable<IVehicle>, IEquatable<Bike>
{
	public string Brand { get; set; }
	public string Make { get; set; }
	public int Year { get; set; }
	public VehicleTypes VehicleType { get; set; } = VehicleTypes.Bike;

	public Bike(string brand, string make, int year)
	{
		Brand = brand;
		Make = make;
		Year = year;
	}

	public int CompareTo(IVehicle other)
	{
		if (other == null)
			return 1;
		int ret = Brand.CompareTo(other.Brand);
		if (ret != 0)
			return ret;
		return Make.CompareTo(other.Make);
	}

	public bool Equals(Bike other) => other.Brand == Brand && other.Make == Make;

	public override string ToString()
	{
		return $"{Brand}; {Make}; {Year}";
	}
}