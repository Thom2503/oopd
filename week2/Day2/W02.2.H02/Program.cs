using System;

namespace Program;

public class Program
{
	public static void Main(string[] args)
	{
		ToDo todo = new ToDo();
		todo.AddTask("Clean my room");
		todo.AddTask("Ask someone out");
		Console.WriteLine(todo.Report());
		Task foundTask = todo.GetTask("Clean my room");
		foundTask.Done();
		Console.WriteLine(foundTask.Info());
	}
}