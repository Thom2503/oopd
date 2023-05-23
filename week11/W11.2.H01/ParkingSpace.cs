public class ParkingSpace
{
	public readonly int Row, Col, Size;
	public bool IsOccupied { get => ParkedVehicle is Vehicle; }
	public Vehicle ParkedVehicle;

	public ParkingSpace(int row, int col, int size)
	{
		Row = row;
		Col = col;
		Size = size;
	}

	public bool ParkVehicle(Vehicle vehicle)
	{
		if (IsOccupied == true)
			return false;

		ParkedVehicle = vehicle;
		return true;
	}

	public Vehicle? GetVehicle() => IsOccupied == true ? ParkedVehicle : null;
}