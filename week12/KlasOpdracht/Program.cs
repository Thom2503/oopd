public class Program
{
    public static void Main()
    {
        //This is the given dictionary tree: 
        Dictionary<string, object> dirTree = new Dictionary<string, object>
        {
            { "education", new Dictionary<string, object> {
                    { "highSchool", new Dictionary<string, object>() },
                    { "bachelor", new Dictionary<string, object>() }
                }
            },
            { "employers", new Dictionary<string, object>() },
            { "family", new Dictionary<string, object>() },
            { "finance", new Dictionary<string, object> {
                    { "2019", new Dictionary<string, object>() },
                    { "2020", new Dictionary<string, object>() },
                    { "2021", new Dictionary<string, object>() }
                }
            },
            { "health", new Dictionary<string, object>() },
            { "home", new Dictionary<string, object>() }
        };
        //This is how your function will be called: 
        PrintAllDirs(dirTree, ".");
        // The program should print the following: 
        // ./education
        // ./education/highSchool
        // ./education/bachelor
        // ./employers
        // ./family
        // ./finance
        // ./finance/2019
        // ./finance/2020
        // ./finance/2021
        // ./health
        // ./home
    }
    public static void PrintAllDirs(Dictionary<string, object> directory, string path)
    {
		foreach (KeyValuePair<string, object> dir in directory)
		{
			Console.WriteLine($"{path}/{dir.Key}");
			if (dir.Value is IDictionary<string, object>)
				PrintAllDirs((Dictionary<string, object>)directory[dir.Key], $"{path}/{dir.Key}");
		}
    }
}