using System;

public class Program
{
	public static void Main(string[] args)
	{
		int iUserNum = Convert.ToInt32(Console.ReadLine());
		int iUserLog = Convert.ToInt32(Console.ReadLine());
		Console.WriteLine(RecursiveLog(iUserNum, iUserLog));
	}

	public static int RecursiveLog(int num, int logBase) => num < logBase ? 0 : 1 + RecursiveLog(num / logBase, logBase);
}