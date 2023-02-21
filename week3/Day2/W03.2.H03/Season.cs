public class Season
{
	public int Year;
	public List<Race> Races;
	public List<Team> Teams;
	public List<int> Points = new List<int>() {25, 18, 15, 12, 10, 8, 6, 4, 2, 1};

	public Season(int iYear, List<Race> lRaces, List<Team> lTeams)
	{
		Year = iYear;
		Races = lRaces;
		Teams = lTeams;
	}

	public void RunSeason()
	{
		Random rand = new Random();
		List<Driver> lDrivers = new List<Driver>();
		this.Teams.ForEach((x) => x.Drivers.ForEach((d) => lDrivers.Add(d)));
		foreach (Race race in this.Races)
		{
			List<Driver> lRandomDrivers = lDrivers.OrderBy(x => rand.Next()).Take(10).ToList();
			for (int i = 0; i < lRandomDrivers.Count(); i++)
			{
				lRandomDrivers[i].UpdatePoints(this.Points[i]);
			}
			Driver dWinner = lRandomDrivers[0];
			Team dTeam = this.Teams.Where(x => x.Drivers.Contains(dWinner)).ToList()[0];
			Console.WriteLine($"{dWinner.Name} of {dTeam.Name} has won the {race.RaceName} Grand Prix!");
		}
	}

	public void SeasonResults()
	{
		Dictionary<string, int> lDrivers = new Dictionary<string, int>();
		this.Teams.ForEach((x) => x.Drivers.ForEach((d) => lDrivers[d.Name] = d.Points));
		int i = 1;
		Console.WriteLine();
		foreach (KeyValuePair<string, int> kvp in lDrivers.OrderByDescending(x => x.Value))
		{
			i++;
			Console.WriteLine($"{i.ToString().PadLeft(2)}. {kvp.Key}: {kvp.Value}");
		}
	}
}