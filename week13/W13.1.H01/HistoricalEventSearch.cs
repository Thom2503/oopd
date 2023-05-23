using Newtonsoft.Json;

public static class HistoricalEventSearch
{
    public static List<HistoricalEvent> ReadEvents(string dataset)
    {
        StreamReader reader = new StreamReader(dataset);
        string jsonString = reader.ReadToEnd();
        reader.Close();
        return JsonConvert.DeserializeObject<List<HistoricalEvent>>(jsonString)!;
    }

	public static List<HistoricalEvent> SearchInDescription(List<HistoricalEvent> events, string search)
	{
		return events.Where(_event => _event.Description.Contains(search)).ToList();
	}

	public static List<HistoricalEvent> SearchBetweenYears(List<HistoricalEvent> events, int fromYear, int toYear)
	{
		return events.Where(_event => _event.Year >= fromYear && _event.Year <= toYear).ToList();
	}

	public static int AverageEventYear(List<HistoricalEvent> events)
	{
		return (int)Math.Floor(events.Average(_event => _event.Year));
	}
}