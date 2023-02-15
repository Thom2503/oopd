public class Player
{
	public string Name;
	public int Points;
	public int Skill;
	public int Intelligence;
	public int Knowledge;

	public Player(string strName, int iSkill, int iIntelligence, int iKnowledge)
	{
		Name = strName;
		Skill = iSkill;
		Intelligence = iIntelligence;
		Knowledge = iKnowledge;
	}

	public void Score()
	{
		this.Points++;
	}

	public static Player? WhoIsWinning(Player p1, Player p2)
	{
		if (p1.Points == p2.Points)
			return null;

		return p1.Points > p2.Points ? p1 : p2;
	}
}