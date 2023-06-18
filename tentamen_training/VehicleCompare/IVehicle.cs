public interface IVehicle : IComparable<IVehicle>
{
	public string Brand { get; set; }
	public string Make { get; set; }
	public int Year { get; set; }
	public VehicleTypes VehicleType { get; set; }
}