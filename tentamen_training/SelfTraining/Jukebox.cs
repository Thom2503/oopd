public class Jukebox : IPlayer
{
	private Random _rand = new Random();
	public string ID { get; }
	public List<Song> Songs = new List<Song>();
	private Song _currentSong { get; set; }

	public Jukebox(List<Song> songs)
	{
		Songs = songs;
		_currentSong = songs[0];
		ID = $"Jukebox-{_rand.Next(0,10)}";
	}

	public void Play() => Console.WriteLine(_currentSong.SongText);

	public void Next()
	{
		int currentIdx = Songs.IndexOf(_currentSong);
		if ((currentIdx + 1) == Songs.Count())
			return;
		
		_currentSong = Songs[++currentIdx];
	}

	public void Previous()
	{
		int currentIdx = Songs.IndexOf(_currentSong);
		if (currentIdx == 0)
			return;
		
		_currentSong = Songs[--currentIdx];
	}

	public string NowPlaying()
	{
		return $"{ID} is playing {_currentSong.ToString()}";
	}
}