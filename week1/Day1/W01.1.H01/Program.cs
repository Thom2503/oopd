using System;

namespace Program;

public class Program
{
    public static void Main(string[] args)
    {
        Console.Write("How many seconds?\n>");
        long seconds = Convert.ToInt64(Console.ReadLine());

        long minutes = seconds / 60;
        long remainingSeconds = seconds % 60;
        long hours = minutes / 60;
        long remainingMinutes = minutes % 60;

        Console.WriteLine($"Hours: {hours}");
        Console.WriteLine($"Minutes: {remainingMinutes}");
        Console.WriteLine($"Seconds Left: {remainingSeconds}");
    }
}