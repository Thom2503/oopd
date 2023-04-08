public class Song
{
	private Random _rand = new Random();
	public string ID { get => $"{Name}-{_rand.Next(0,10)}"; }
	public string Name { get; }
	public string Musician { get; }
	public string SongText { get; set; }
	public int Length { get; }	

	public Song(string name, string musician, int length)
	{
		Name = name;
		Musician = musician;
		Length = length;
	}

	public void SetSongText(string songText) => SongText = songText;

	public override string ToString() => $"{Name} - {Musician} ({Length})";
}