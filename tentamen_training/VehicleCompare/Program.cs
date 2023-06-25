using System;

namespace Program;

public class Program
{
	public static void Main(string[] args)
	{
		Garage garage = new Garage();
		garage.Add(new Truck("Ford", "F150", 2015));
		garage.Add(new Car("BMW", "M5", 1990));
		garage.Add(new Car("Toyota", "AE86", 1986));
		garage.Add(new Bike("Vanmoof", "S5", 2020));
		garage.Add(new Truck("Dodge", "Ram", 2005));
		garage.Add(new Car("Mazda", "RX-7", 1997));
		garage.Add(new Car("Toyota", "Corolla", 2003));
		garage.Add(new Bike("Vanmoof", "S3", 2018));

		foreach (IVehicle _vehicle in garage.Vehicles)
			Console.WriteLine(_vehicle.ToString());

		Console.WriteLine("------------------");
		Console.WriteLine(garage.GetFirstInQueue().ToString());
		Console.WriteLine("------------------");
		garage.Remove();
		garage.Sort();
		foreach (IVehicle _vehicle in garage.Vehicles)
			Console.WriteLine(_vehicle.ToString());

		Console.WriteLine("------------------");
		Console.WriteLine(garage.SearchVehicle<Car>("Toyota", "AE86", 1986).ToString());
		Console.WriteLine(garage.SearchVehicle<Truck>("Toyota", "AE86", 1986) == null);
		Console.WriteLine(garage.SearchVehicle<Bike>("Vanmoof", "S5").ToString());
		//Console.WriteLine(VehilceChecker.HasMatch(tmpVehicles, (x) => x == garage.SearchVehicle<Car>("Toyota", "AE86", 1986)));
		Console.WriteLine("------------------");
		Dictionary<VehicleTypes, int> amountPerType = new Dictionary<VehicleTypes, int>();
		List<IVehicle> tmpVehicles = new List<IVehicle>(garage.Vehicles);
		foreach (VehicleTypes type in Enum.GetValues(typeof(VehicleTypes)))
		{
			tmpVehicles = new List<IVehicle>(garage.Vehicles);
			amountPerType[type] = garage.GetAmountOfType(tmpVehicles, type);
		}
		foreach (KeyValuePair<VehicleTypes, int> kvp in amountPerType)
		{
			Console.WriteLine($"The Type {kvp.Key} has {kvp.Value} amount");
		}
		garage.Vehicles.Where(x => x.VehicleType == VehicleTypes.Bike).ToList().ForEach(x => Console.WriteLine($"{x.Brand} {x.Make} is a Bike!"));
		garage.Vehicles.Where(x => x.Year >= 2000)
		               .GroupBy(x => x.VehicleType)
					   .ToList()
					   .ForEach(X => Console.WriteLine($"There are {X.Count()} amount of {X.Key}"));
		Console.WriteLine("---------------");
		Console.WriteLine($"The oldest vehicle is: {garage.FindOldestVehicle(new List<IVehicle>(garage.Vehicles))}");
		Console.WriteLine($"The youngest vehicle is: {garage.FindYoungestVehicle(new List<IVehicle>(garage.Vehicles))}");
		Console.WriteLine("---------------");
		garage.DoActionPerType(VehicleTypes.Car, (x) => {
			Console.WriteLine($"Removing {x.ToString()}");
			garage.Remove(x);
		});
		Console.WriteLine("---------------");
		foreach (IVehicle _vehicle in garage.Vehicles)
			Console.WriteLine(_vehicle.ToString());
	}
}