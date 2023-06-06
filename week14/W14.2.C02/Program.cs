string[] persons = new string[] { "Dave", "John", "Peter", "Johanna", "Bart", "Henk", "Marie" };
string[] students = new string[] { "Dave", "Micheal", "Roxanne", "Johanna", "John", "Bart", "Henk" };

Console.WriteLine("These names are in both datasets:");
persons.Intersect(students)
       .ToList()
	   .ForEach(x => Console.WriteLine(x));


Console.WriteLine();
Console.WriteLine("These names are unique:");
persons.Concat(students)
       .Distinct()
	   .OrderBy(x => x)
	   .ToList()
	   .ForEach(x => Console.WriteLine(x));