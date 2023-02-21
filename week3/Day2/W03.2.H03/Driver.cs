public class Driver
{
	public string Name;
	public int Points;

	public Driver(string strName) => Name = strName;

	public void UpdatePoints(int iPoints) => this.Points += iPoints;
}