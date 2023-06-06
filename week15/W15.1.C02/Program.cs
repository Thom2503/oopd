var array = new int[][] {
    new int[]{ 1, 2, 3, 4, 5 },
    new int[]{ 6, 7, 8, 9, 10 },
    new int[]{ 11, 12, 13, 14, 15 },
    new int[]{ 16, 17, 18, 19, 20 },
    new int[]{ 21, 22, 23, 24, 25 }
};

var expr = from row in Enumerable.Range(0, array.Length)
           from col in Enumerable.Range(0, array.Length)
		   select array[col][row];

expr.ToList().ForEach(x => Console.Write(x));