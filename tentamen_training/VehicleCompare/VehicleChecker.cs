public static class VehilceChecker
{
	public static bool HasMatch(List<IVehicle> vehicles, Func<IVehicle, bool> func)
	{
		for (int i = 0; i < vehicles.Count(); i++)
		{
			if (func(vehicles[i]) == true)
			{
				return true;
			}
			else
			{
				vehicles.RemoveAt(i);
				return HasMatch(vehicles, func);
			}
		}
		return false;
	}
}