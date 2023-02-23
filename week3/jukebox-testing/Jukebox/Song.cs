
public class Song
{
    public string Title;
    public string Artist;
    public int Duration;

    public Song(string title, string artist, int duration)
    {
        Title = title;
        Artist = artist;
        Duration = duration;
    }

    public string Info()
    {
        TimeSpan t = TimeSpan.FromSeconds(Duration);
        return $"'{Title}' performed by '{Artist}' - {t.Minutes:D2}m:{t.Seconds:D2}s";
    }
}