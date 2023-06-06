string input = Console.ReadLine();

var epxr = from chr in input
           group chr by chr into chr_group
		   orderby chr_group.Count() descending
		   select chr_group;

Console.WriteLine(epxr.ToList().First().Key);