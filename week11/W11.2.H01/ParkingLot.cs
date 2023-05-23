public class ParkingLot
{
	public readonly int[] NumColsArr = new int[];

	public ParkingLot(int[] arr)
	{
		foreach (int i in arr)
		{
			for (int j = 0; j < i; j++)
			{
				ParkingSpace parkingSpace = new ParkingSpace(i, j, i > 4 ? 1 : 2);
				NumColsArr[i][j] = parkingSpace;
			}
		}
	}

	public bool ParkVehicle(ParkingSpace parkingSpace, Vehicle vehicle)
	{
		if (parkingSpace.IsOccupied == true)
			return false;

		parkingSpace.ParkedVehicle = vehicle;
		return true;
	}
}