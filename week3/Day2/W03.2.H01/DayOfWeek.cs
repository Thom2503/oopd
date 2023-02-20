public class DayOfWeek
{
	public int StartIndex;

	public DayOfWeek(int iStartIndex) => StartIndex = iStartIndex;

	public static string IndexToDay(int iIndex)
	{
		iIndex = iIndex < 0 ? iIndex + 7  : iIndex % 7;
		return (iIndex) switch
		{
			1 => "Tuesday",
			2 => "Wednesday",
			3 => "Thursday",
			4 => "Friday",
			5 => "Saturday",
			6 => "Sunday",
			_ => "Monday"
		};
	}

	public string CurrentDay()
	{
		return DayOfWeek.IndexToDay(this.StartIndex);
	}

	public bool IsWeekend()
	{
		int iIndex = this.StartIndex < 0 ? this.StartIndex + 7 : this.StartIndex % 7;
		return (iIndex == 5) || (iIndex == 6);
	}

	public void NextDay()
	{
		this.StartIndex++;
	}
}