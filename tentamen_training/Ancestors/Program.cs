using System;

public class Program
{
	public static void Main(string[] args)
	{
        Pet pet1 = new Pet { Name = "Fluffy" };
        Pet pet2 = new Pet { Name = "Max", Parent = pet1 };
        Pet pet3 = new Pet { Name = "Bella", Parent = pet2 };
        Pet pet4 = new Pet { Name = "Charlie", Parent = pet3 };
        // Count ancestors for pet4
        int ancestorCount = CountAncestors(pet4);
        Console.WriteLine("The number of ancestors for " + pet4.Name + " is " + ancestorCount);
	}

	public static int CountAncestors(Pet pet)
	{
		if (pet.Parent == null)
			return 0;
		return 1 + CountAncestors(pet.Parent);
	}
}