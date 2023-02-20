public class Monster
{
	public string Name;
	public int HP;
	public int Strength;
	public int Experience;
	public bool IsAlive = true;

	public Monster(string strName, int iHP, int iStrength, int iExp)
	{
		Name = strName;
		HP = iHP;
		Strength = iStrength;
		Experience = iExp;
	}

	public void Attack(Player player)
	{
		player.TakeDamage(this.Strength);

		if (player.CurrentHP <= 0)
			player.IsAlive = false;
	}

	public void TakeDamage(int iDamage)
	{
		this.HP -= iDamage;
		if (this.HP <= 0)
			this.HP = 0;
	}
}