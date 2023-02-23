public class MyJukebox
{

    public List<Song> Playlist = new() { };

    public string PlayListDuration()
    {
        TimeSpan t = TimeSpan.FromSeconds(Playlist.Sum(song => song.Duration));
        return $"{t.Minutes:D2}m:{t.Seconds:D2}s";
    }

    public void AddSong(string title, string artist, int duration)
    {
        Playlist.Add(new Song(title, artist, duration));
    }

    public string Info()
    {
        if (Playlist.Count() > 0)
        {
            string s = "";
            foreach (var song in Playlist){
                s = s + song.Info() + "\n";
            } 
            return s;
        }
        else
        {
            return "No songs currently in Playlist!";
        }

    }

}