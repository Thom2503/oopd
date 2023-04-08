using System;

namespace Program;

public class Program
{
	public static void Main(string[] args)
	{
		List<Vehicle> vehicles = new List<Vehicle>()
		{
			new Bike(-100, 1, 2, "Gazelle"),
			new Car(30000, 5, 4, 3, "Volkswagen", "Golf", 1987),
			new Car(150000, 5, 4, 4, "Volvo", "V40", 2013),
			new Bike(0, 2, 2, "Tendem Bike"),
			new Bike(10000, 1, 3, "Trike"),
			new Car(3000, 8, 6, 5, "Mercedes", "6x6", 2018)
		};

		Random rand = new Random();
		foreach (Vehicle _vehicle in vehicles)
		{
			_vehicle.Drive(rand.Next(10, 100));
			Console.WriteLine(_vehicle.Mileage);
			_vehicle.Honk();
		}
	}
}