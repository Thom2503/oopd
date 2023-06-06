using Newtonsoft.Json;

public static class InventoryManager
{
    public static List<Plant> ReadInventory(string dataset)
    {
        string jsonString = File.ReadAllText(dataset);
        return JsonConvert.DeserializeObject<List<Plant>>(jsonString)!;
    }

    public static List<Plant> DetectLowInventory(List<Plant> plants)
    {
        return plants.Where(p => p.Stock < 5).OrderBy(p => p.Stock).ToList();
    }

    public static List<Plant> SearchByCategory(List<Plant> plants, string category)
    {
        return plants.Where(p => p.Category == category).ToList();
    }

    public static List<Plant> LastSoldItems(List<Plant> plants)
    {
        DateOnly maxDate = plants.Max(p => p.LastSold);
        return plants.Where(p => p.LastSold == maxDate).ToList();
    }

    public static List<Plant> PotentialRemoval(List<Plant> plants)
    {
        return plants.Where(p => p.LastSold.AddMonths(10) < DateOnly.FromDateTime(DateTime.Now) && p.Stock >= 10).ToList();
    }
}