public class Car : IVehicle, IComparable<IVehicle>, IEquatable<Car>
{
	public string Brand { get; set; }
	public string Make { get; set; }
	public int Year { get; set; }
	public VehicleTypes VehicleType { get; set; } = VehicleTypes.Car;

	public Car(string brand, string make, int year)
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
		ret = Make.CompareTo(other.Make);
		if (ret != 0)
			return ret;
		return Year.CompareTo(other.Year);
	}

	public bool Equals(Car other)
	{
		return Brand == other.Brand && Make == other.Make && Year == other.Year;
	}

	public override string ToString() => $"{Brand}; {Make}; {Year}";
}