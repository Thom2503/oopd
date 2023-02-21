public class Team
{
	public string Name;
	public List<Driver> Drivers = new List<Driver>();

	public Team(string strName) => Name = strName;

	public void ContractDriver(Driver driver)
	{
		this.Drivers.Add(driver);
	}
}