public class Player
{
	public string Name;
	public int MaxHP = 10;
	public int CurrentHP;
	public int Strength = 3;
	public static int Level = 1;
	public static int Experience = 0;

	public bool IsAlive = true;

	public Player(string strName, int iPlayerHP, int iPlayerStregth)
	{
		Name = strName;
		MaxHP += iPlayerHP;
		CurrentHP = MaxHP;
		Strength += iPlayerStregth;
	}

	public int GetLevel() => Player.Level;

	public void Attack(Monster monster)
	{
		monster.TakeDamage(this.Strength);
		if (monster.HP <= 0)
		{
			monster.IsAlive = false;

			Player.Experience += monster.Experience;
			int iCurrentExperience = World.ExperienceChart[Player.Level - 1]; 
			if (Player.Experience >= iCurrentExperience)
			{
				for (int i = Player.Level - 1; i < World.ExperienceChart.Count(); i++)
				{
					if (Player.Experience < World.ExperienceChart[i])
						break;
					Player.Level++;
					this.MaxHP += 10;
					this.Strength += 3;
				}
			}
		}
	}

	public void TakeDamage(int iDamage)
	{
		this.CurrentHP -= iDamage - Convert.ToInt32(Math.Floor(this.Strength / 4.0));
	}

	public void GiveExperience()
	{
		Player.Level = 2;
		for (int i = 0; i < World.ExperienceChart.Count(); i++)
		{
			if (Player.Experience < World.ExperienceChart[i])
				break;
			Player.Level++;
			this.MaxHP += 10;
			this.Strength += 3;
		}
	}
}