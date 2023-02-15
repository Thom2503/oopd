using System;

namespace Program;

public class Program
{
	public static void Main(string[] args)
	{
		CarFactory carFactory = new CarFactory(5);
		for (int i = 0; i <= 10; i++)
		{
			LimitedEditionCar? newCar = carFactory.ProduceLimitedEditionCar();
			Console.WriteLine(newCar == null ? "Cannot produce more cars" : newCar.ChassisNumber);
		}
	}
}