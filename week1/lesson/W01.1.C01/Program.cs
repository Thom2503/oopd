using System;

namespace Program;

public class Program
{
    public static void Main(string[] args)
    {
        Console.Write("Hello. Please enter your last name.\n>");
        string lastName = Console.ReadLine();
        Console.Write("What is the initial of your first name?\n>");
        char initial = Convert.ToChar(Console.ReadLine());
        Console.WriteLine($"Welcome to the course, {initial} {lastName}. We will watch your career with great interest.");
    }
}