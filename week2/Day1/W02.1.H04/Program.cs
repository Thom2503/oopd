using System;

namespace Program;

public class Program
{
	public static void Main(string[] args)
	{
		Artifact artifact = new Artifact(100.0, 33.33);
		Artifact artifact2 = new Artifact(100.0, 33.33);

		Console.WriteLine(artifact.isEqualTo(artifact2));
	}
}