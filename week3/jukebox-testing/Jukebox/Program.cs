Console.WriteLine("Welcome to my jukebox app!");

MyJukebox jukebox = new MyJukebox();
jukebox.AddSong("Best song in the world", "Unkown artist", 120);
jukebox.AddSong("Rain in blood", "Slayer", 340);
jukebox.AddSong("Wanted, Dead or Alive", "Bon Jovi", 460);

Console.Write(jukebox.Info());
Console.WriteLine(jukebox.PlayListDuration());

jukebox.AddSong("Level Up", "Ciara", 160);
Console.Write(jukebox.Info());
Console.WriteLine(jukebox.PlayListDuration());