Console.Write("Input string: ");
var str = Console.ReadLine();
var expr = from chr in str.ToCharArray()
           group chr by chr into chr_group
		   select new { Key = chr_group.Key, Count = chr_group.Count()};

expr.ToList().ForEach(x => Console.WriteLine($"Char [{x.Key}]: {x.Count}"));