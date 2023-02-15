public class Game
{
	public Player Player1;
	public Player Player2;

	public Game(Player p1, Player p2)
	{
		Player1 = p1;
		Player2 = p2;
	}

	public Player Round1()
	{
		Player p1 = this.Player1;
		Player p2 = this.Player2;

		if (p1.Intelligence >= p2.Intelligence && p1.Knowledge >= p2.Knowledge && p1.Skill >= p2.Skill)
			return p1;
		
		return p2;
	}

	public Player Round2()
	{
		Player p1 = this.Player1;
		Player p2 = this.Player2;

		if (p1.Intelligence >= p2.Intelligence && p1.Knowledge >= p2.Knowledge && p1.Skill >= p2.Skill)
			return p1;
		
		return p2;
	}

	public Player Round3()
	{
		Player p1 = this.Player1;
		Player p2 = this.Player2;

		if (p1.Intelligence >= p2.Intelligence && p1.Knowledge >= p2.Knowledge && p1.Skill >= p2.Skill)
			return p1;
		
		return p2;
	}

	public static string Instructions()
	{
		return "Win at least 2 rounds to win!";
	}
}