public class Player
{
    //Your magic here
	public string Name;
	public int Power;
	public int HealthPoints;

	public Player(string name, int iPower)
	{
		Name = name;
		Power = iPower;
		HealthPoints = 100;
	}

	public bool IsAlive()
	{
		return (HealthPoints <= 0) != true;
	}

	public void TakeDamage(int iDamage)
	{
		if (iDamage > HealthPoints)
		{
			HealthPoints = 0;
		} else
		{
			HealthPoints -= iDamage;
		}
	}
}