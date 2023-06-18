public enum VehicleTypes
{
	Bike,
	Car,
	Truck
}

public class Garage
{
	public List<IVehicle> Vehicles { get; set; }
	public Queue<IVehicle> QueuedVehicles { get; set; }
	private const int MaxAmount = 5;

	public Garage()
	{
		Vehicles = new List<IVehicle>();
		QueuedVehicles = new Queue<IVehicle>();
	}
	
	public void Add(IVehicle vehicle)
	{
		if (Vehicles.Count() >= MaxAmount)
			QueuedVehicles.Enqueue(vehicle);
		else
			Vehicles.Add(vehicle);

	}
	
	public void Remove()
	{
		Vehicles.RemoveAt(0);
		Vehicles.Add(QueuedVehicles.Dequeue());
	}

	public IVehicle GetFirstInQueue() => QueuedVehicles.Peek();

	public void Sort() => Vehicles.Sort();

	public T SearchVehicle<T>(string brand, string make, int year)
	{
		foreach (IVehicle _vehicle in Vehicles)
		{
			if (_vehicle is T)
			{
				if (_vehicle.Year == year && _vehicle.Brand == brand && _vehicle.Make == make)
					return (T)_vehicle;
			}
		}
		return default(T);
	}

	public T SearchVehicle<T>(string brand, string make)
	{
		foreach (IVehicle _vehicle in Vehicles)
		{
			if (_vehicle is T)
			{
				if (_vehicle.Brand == brand && _vehicle.Make == make)
					return (T)_vehicle;
			}
		}
		return default(T);
	}
	
	public int GetAmountOfType(List<IVehicle> vehicles, VehicleTypes vehicleType)
	{
		if (vehicles.Count() <= 0)
			return 0;
		if (vehicles[0].VehicleType == vehicleType)
		{
			vehicles.RemoveAt(0);
			return 1 + GetAmountOfType(vehicles, vehicleType);
		}
		else
		{
			vehicles.RemoveAt(0);
			return 0 + GetAmountOfType(vehicles, vehicleType);
		}
	}
}